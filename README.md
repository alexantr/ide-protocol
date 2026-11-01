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
