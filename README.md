<!-- README.md -->

<h1 align="center">
  <img src="https://img.shields.io/badge/-Event%20Participant%20Badge%20Scanner%20App-blue" alt="Event Participant Badge Scanner App">
</h1>

<p align="center">
  <em>ASP .NET MVC V6 + SQL Server + Visual Studio</em>
</p>

<p align="center">
  <strong>Made for an event to check the participants' badges by scanning the QR code. The app fetches data from the database to ensure:</strong>
</p>

<ol>
  <li>The QR code is not scanned twice (Date Last Scan ≠ NULL && QR Exists).</li>
  <li>The QR code is scanned for the first time, allowing the participant to enter the event successfully (Date Last Scan == NULL && QR Exists).</li>
  <li>The QR code doesn't exist in the database, detecting unvalid Qr, not allowing participant to enter event.</li>
</ol>

<p align="center">
  <strong>Note:</strong> This app was developed in a few hours with minimal styling effort.
</p>

---

## Functionality

The main functionalities of the application include:

1. **Scanning QR Codes:** Participants' badges are equipped with QR codes which are scanned using the application.

2. **Checking Database:** The application fetches data from the database to verify:

   - Whether the QR code has already been scanned, as a participant with a scanned badge should not be allowed to enter again.
   
   - If it's the first time the QR code is being scanned, allowing the participant to enter the event successfully.
   
   - Whether the QR code scanned don't exist in database "fake ", not allowing participant to enter the event.

---

## Development Details

This application was developed in a few hours, with a primary focus on functionality rather than elaborate styling. As such, minimal effort was put into styling since it was not a requirement from the client.

---

## Setup Instructions

To set up the application locally, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Set up the SQL Server database according to the schema defined in the project.
4. Configure the database connection string in the application's configuration files.
5. Build and run the application to start scanning participant badges.

---

## Technologies Used

- ASP .NET MVC V6
- SQL Server
- Visual Studio

---

## Contributors

- Imane Belhaj

---


