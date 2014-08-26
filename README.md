This code is not production ready. It is meant to help you integrate quickly with SendGrid when developing for Windows Phone 8.1. You will need to incorporate error handling and testing. 

The companion blog post, which explains the usage of this code can be found [here](http://sendgrid.com/blog/tracking-email-using-microsoft-azure-sendgrid-event-webhook-part-2). 

**tl;dr;** This code uses the [SendGrid Web API](https://sendgrid.com/docs/API_Reference/Web_API/index.html) to show your [email statistics](https://sendgrid.com/docs/API_Reference/Web_API/Statistics/index.html) in a Windows Phone 8.1 app.

## Getting Started

This code was tested in Microsoft Visual Studio Express 2013 for Windows.

Minimally, you will need a [free SendGrid account](http://sendgrid.com/transactional-email/pricing). 

Enter your SendGrid credentials [here](https://github.com/thinkingserious/SendGridStatsWindowsPhone8/blob/master/SendGridStats/SendGridStats.Shared/App.xaml.cs) where the SendGrid API object is instantiated.

## Info & Help

If you create something cool with this code, let us know so we can include you in the [SendGrid Developer Community](http://sendgrid.com/developers/developers).

Please let me know how I can improve this tutorial with a pull request or open an issue. Thanks! 

Big thanks to [Alex Reed](http://twitter.com/alexerax) for providing the original source code!

## License

This code is released under the [MIT License](http://opensource.org/licenses/MIT)
