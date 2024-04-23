# M-Pesa Callback API

## Overview:

This project implements an ASP.NET Core Web API to handle M-Pesa callback notifications. It provides an endpoint (`/MpesaCallback`) where M-Pesa can send callback data, such as transaction details, after payment processing. The API parses the callback data, logs it, and optionally processes it further, such as updating database records. It's designed to be easily deployable on an IIS server and customizable to suit specific M-Pesa integration requirements.

## Installation:

To use this API:

1. Clone or download the repository.
2. Set up the project in Visual Studio or your preferred IDE.
3. Customize the `HandleMpesaCallback` method in the `MpesaCallbackController` to handle M-Pesa callback data as required.
4. Publish the project and deploy it to an IIS server.
5. Configure your M-Pesa integration to send callback notifications to the `/MpesaCallback` endpoint of your deployed API.

## Usage:

- **Endpoint:** `/MpesaCallback`
- **HTTP Method:** POST
- **Request Body:** JSON format containing M-Pesa callback data
- **Response:** Returns an appropriate HTTP status code and response body

## Contributing:

Contributions are welcome! If you have any suggestions, bug fixes, or improvements, feel free to open an issue or submit a pull request.

## License:

This project is licensed under the [MIT License](LICENSE).
