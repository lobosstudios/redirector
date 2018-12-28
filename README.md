# ASP.NET Core HTTP-to-HTTPS Redirector

This is a very simple ASP.NET Core web app. It takes an HTTP URL, modifies the scheme (leaving all of the other parts of the URL intact), and does a redirect to the modified URL.

It is released under the [MIT License](https://opensource.org/licenses/MIT).

## Installation
This web app should run equally well under Kestrel or inside IIS. I used Web Deploy to publish it to my production Windows 2016 server, where it runs in-process in IIS. If you do want to use this web app under IIS, don't forget to install the [ASP.NET Hosting Bundle](https://www.microsoft.com/net/permalink/dotnetcore-current-windows-runtime-bundle-installer).

## Questions?
Feel free to [ask me any questions you may have](mailto:steve+redirector@LobosStudios.com).

