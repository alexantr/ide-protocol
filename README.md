# ide protocol

This app allows to use ```ide://``` protocol to open a file in VS Code.

Following string must be specified as an editor in your app:

```bash
ide://open?url=file://%f&line=%l
```

Alternative syntax is supported:

```bash
ide://open?file=%f&line=%l
```

More reading about protocol handlers: http://pla.nette.org/en/how-open-files-in-ide-from-debugger.

## Install

REG file example:

```
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\ide]
@="URL:ide Protocol"
"URL Protocol"=""

[HKEY_CLASSES_ROOT\ide\shell]

[HKEY_CLASSES_ROOT\ide\shell\open]

[HKEY_CLASSES_ROOT\ide\shell\open\command]
@="\"C:\\Programs\\ide-protocol\\ide-protocol.exe\" \"%1\""


```

## Uninstall

REG file example:

```
Windows Registry Editor Version 5.00

[-HKEY_CLASSES_ROOT\ide]


```