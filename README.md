# ssn_371_WindowsService_HostAPI

Basic Windows Service API.

Set the environment variable ssn-371-ServiceAPIHostName to access the service

setx ssn-371-ServiceAPIHostName "http://localhost:8801" /m

Test it with the url:
http://localhost:8801/value/get

Service start and stop methods log enteries to the event log 'ssn_log'.


