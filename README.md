# RepeaterQTH [![Build ASP.Net Core without deploy - repeaterqth](https://github.com/jsb2092/RepeaterQTH/actions/workflows/build_repeaterqth.yml/badge.svg)](https://github.com/jsb2092/RepeaterQTH/actions/workflows/build_repeaterqth.yml)

RepeaterQTH is a web site that is designed to keep track of Amateur Radio Repeaters.  This is an 
open source project that anyone can contribute to.  The site is also designed to be wiki-like, 
where anyone can make changes and the changes are logged for anyone to see and revert if they 
feel that the changes were not made correctly.  Exporting of repeaters to known formats for importing
into radios is available and mapping features are provided to allow viewing repeaters on maps.  
Searching by location, feature and mode are also available options.

Currently, an alpha production version of the site is running at <https://repeaterqth.com>.  Bug should
be reported on the issue tracker on github.

## Building

This is built with dotnet 5.0.  You can get dotnet 5.0 from <https://dotnet.microsoft.com/download>.  
Once dotnet 5.0 is installed you can go to the directory you downloaded the code into and run
"dotnet build" to build the code.  All dependencies are managed with nuget packages, and the build 
should simply work.

## Configuring

In order to successfully run the application you will need to setup several services and databases.
While the code will build without these, it will not run successfully.  The connections to services
are configured in the connection.json file.

### Config.json

In order to use this, copy connection.json.sample to connection.json and fill in the blanks, detailed
here:


- "connectionString": "mongodb+srv:// < connection string >"
  - This is your mongo connection string.  Details for the collection to be defined in Mongo 
        are below
- "geolite-user": "",
- "geolite-key": "",
  - Geolite is used for location services.  
  - You will need a geolite from here <https://dev.maxmind.com/geoip/docs/web-services/requests?lang=en>
- "Google-clientID": "",
- "Google-clientSecret": "",
  - Google authentication allows users to sign in with their google account.
  - In the Credentials page: <https://console.developers.google.com/apis/credentials>, select CREATE CREDENTIALS > OAuth client ID.
  - In the Application type dialog, select Web application. Provide a Name for the app.
  - In the Authorized redirect URIs section, select ADD URI to set the redirect URI. Example redirect URI: <https://localhost:{PORT}/signin-google>, where the {PORT} placeholder is the app's port.
  - Select the CREATE button.
  - Save the Client ID and Client Secret for use in the app's configuration.
- "SendGridKey": ""
  - You will need a to setup a sender at <https://docs.sendgrid.com/ui/sending-email/senders> after creating an account and then create an API key

### Mongo Collections

You will need several mongo collections for this.  They are not provided for you.  By default they are in a database named "directory".  Sample documents are provided for you when necessary, collections without sample documents will be populated automatically.

- repeater
  - This will be populated when you add a repeater automatically.
- ip_cache
  - This will be populated when ip loookups for location are done.
- usa_counties
  - {"county":"Riverside","state_name":"California"}
- usa_state_location
  - {"state":"Alaska","lat":"63.588753","lng":"-154.493062"}
- zipcodes
  - {"zip":"00602","lat":18.361945,"lng":-67.175597}
