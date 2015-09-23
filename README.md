# dndate

C# console application to check how [DateTime format strings][1] work. Uses the current UTC time.

## Usage

	dndate [format]
	
## Examples

	dndate hh-mm-ss-ff
	10-20-25-95

	dndate O
	2015-09-23T10:20:43.8439938Z
	
## Install

Clone the app and add it to your `%PATH%` or follow my power-user guide to [mimic /usr/bin in Windows][2]

## License

Released under the UNLICENSE, no rights reserved.

-----

By [@SteGriff](https://twitter.com/stegriff)

[1]: https://msdn.microsoft.com/en-us/library/8kb3ddd4%28v=vs.110%29.aspx
[2]: http://stegriff.co.uk/upblog/mimic-usr-bin-in-windows