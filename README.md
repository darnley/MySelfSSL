# MySelfSSL

MySelfSSL is a C# program for dealing with development certificates. It will allow you to create self-signed certificates.

## Installation

### Requirements
* [.NET Framework v4.7.1](https://www.microsoft.com/en-us/download/details.aspx?id=56115 "Microsoft's download page")

## Usage

- Create a new Certificate Authority (CA)
  - Enter "Certificate Authorities (CA)" tab
  - Insert a common name (eg. Root Development CA) or keep default value
  - Optional: Insert Subject Alternative Names (SANs) to your Certificate Authority (CA).
  - Click "Create certificate" button.
- Create a new Self-Signed Certificate.
  - Enter "Issue Certificate" tab
  - Select the Certificate Authority (CA) in the first listbox that you want to issue certificate.
  - Insert a common name (eg. MySelfSSL Local Development). It will help you to locate the certificate in certificate list.
  - Optional: If you want to use it in IIS, check the checkbox below the common name.
  - In "Subject Alternative Names (SAN)" box, insert the hostnames, domains or another names that you want to issue the certificate (eg. dashboard.local, movie.oo).
  - Click "Create certificate"


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://darnley.mit-license.org/2018)
