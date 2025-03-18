# SendGridDemo

## Overview
SendGridDemo is a simple C# console application that demonstrates how to integrate SendGrid for sending emails. The API key is securely stored in a `.env` file to keep credentials safe.

## Prerequisites
- SendGrid account ([Sign up](https://signup.sendgrid.com/))
- SendGrid API key

## Setup

1. Clone the repository:
   ```sh
   git clone https://github.com/deans-bradley/SendGridDemo.git
   cd SendGridDemo
   ```

2. Install dependencies:
   ```sh
   dotnet restore
   ```

3. Create a `.env` file in the project root and add your SendGrid API key:
   ```env
   SENDGRID_API_KEY=your_sendgrid_api_key
   ```

4. Run the application:
   ```sh
   dotnet run
   ```

## Usage
The application will send a test email using SendGrid. Modify the email recipient and message content in the `Program.cs` as needed.

## Environment Variables
| Variable         | Description                 |
|-----------------|-----------------------------|
| SENDGRID_API_KEY | Your SendGrid API key |

## Dependencies
- [SendGrid C# SDK](https://github.com/sendgrid/sendgrid-csharp)
- [DotNetEnv](https://github.com/tonerdo/dotnet-env) for environment variable management

## License
This project is open-source and available under the [MIT License](LICENSE).