using Microsoft.AspNetCore.Mvc;

using System;
using System.Linq;

using ScanningApp.Models;



namespace ScanningApp.Controllers
{
    public class ScanQrCodeController : Controller
    {
        private readonly UserQrContext _context;

        public ScanQrCodeController (UserQrContext context)
        {
            _context = context;
        }

        public IActionResult ScanQrCode(string qrCode)
        {
            if (string.IsNullOrEmpty(qrCode))
            {
                // If QR code is not provided, render the ScanQrCode view
                return View("ScanQrCode");
            }
            // Check if the QR code exists in the database
            var user = _context.Users.FirstOrDefault(u => u.QrCode == qrCode);

            if (user != null)
            {
                // Check if the QR code has been scanned before
                if (user.DateLastScan.HasValue)
                {
                    // Redirect to the "AlreadyScanned" view
                    return RedirectToAction("AlreadyScanned");
                }
                else
                {
                    // First time scanning, update the DateLastScan to the current date/time
                    user.DateLastScan = DateTime.Now;
                    _context.SaveChanges();

                    // Redirect to the "NewScan" view
                    return RedirectToAction("NewScan");
                }
            }
            else
            {
                // Redirect to the "DontExist" view
                return RedirectToAction("DontExist");
            }
        }

        //public IActionResult ScanQrCode()
        //{
        //    return View();
        //}
        public IActionResult AlreadyScanned()
        {
            return View();
        }

        public IActionResult NewScan()
        {
            return View();
        }

        public IActionResult DontExist()
        {
            return View();
        }
    }
}
