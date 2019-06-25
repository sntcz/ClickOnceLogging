# ClickOnce Logging Settings

Set/reset verbose logging in ClickOnce deployment.
[Original idea](https://robindotnet.wordpress.com/2010/05/31/enhanced-logging-in-clickonce-deployment/).


---------------------------------------

# Description

The log file path and verbosity leves are located in registry.

The log file path is here:
```HKEY_Current_User\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment\LogFilePath```

The verbose logging is here: 
```HKEY_Current_User\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment\LogVerbosityLevel```

Both keys are string (```REG_SZ```). If you want start logging, set log file path
registry key to file. For stop the logging, delete the registry key.

__If you change or set the LogFilePath, it takes effect immediately. 
If you change or set the LogVerbosityLevel, it does not take effect 
until the user logs off and logs back in.__

And there is __no automatic cleanup of the log file__. 
No rollover or any similar function. You must allways turn off
the logging after you don not need it.

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- Set/reset ClickOnce log file path
- Set/reset ClickOnce verbosity level

## License
[MIT](LICENSE.md)