## Demo - Enterprise Library Logging
.Net 4.7.2 Demo for EnterpriseLibrary.Logging v6

Configuration for the following listeners can be found in app.config:
- FormattedEventLogTraceListener
- RollingFlatFileTraceListener
- CustomTraceListenerData (Custom Console Listener)

Example on how to configure and select different formatters for event log & flat file logging.

The configured event log source is **Demo.EnterpriseLibrary.Logging.CLI**

The following regitsry key is needed and will be created if ran with proper access rights:

```
HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\EventLog\Application\Demo.EnterpriseLibrary.Logging.CLI
```

A .reg file in Files\Create EventLog Source.reg can be used to create the registry key mentioned above if needed.