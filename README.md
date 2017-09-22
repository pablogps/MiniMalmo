# MiniMalmo
Minimal example for a website that instantiates (but does not use) the variable AgentHost from Project Malmo (https://github.com/Microsoft/malmo).

This project is the default template for an ASP.NET Web application in Visual Studio. It has been simplified to only contain two pages and no databases.

In Home, there is a button that calls an action that redirects to the second page. Before doing this, the variable AgentHost from Project Malmo is instantiated. This works fine in Visual Studio, but I cannot make it work when publishing to localhost. Other variables from Project Malmo are not an issue (MissionSpec, for example).

Make sure to include the files MalmoNET.dll and MalmoNetnATIVE.dll when publishing.
