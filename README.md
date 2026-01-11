# CFN2CSV

A simple Windows application to convert FNIRSI CFN measurement files to CSV format.

## About

CFN files are produced by the FNIRSI UsbMeter tool when recording measurements from FNIRSI USB testers. This application provides a quick way to convert those files to CSV for analysis in Excel, Google Sheets, or other tools.

## Download

Grab the latest release from the [`release`](release/) folder - just download, unzip, and run. No installation required.

## Usage

1. Run `CFN2CSV.exe`
2. Click "Open CFN File..." and select your `.cfn` file
3. Review the file information displayed
4. Click "Save as CSV..." to export

## Output

The CSV output includes:
- Timestamp
- VBus Voltage
- VBus Current
- D+ Voltage
- D- Voltage
- Power
- Accumulated Capacity
- Accumulated Energy

## Downloads

### FNIRSI USB Tester Software

Download the official FNIRSI UsbMeter software to record CFN files from your device:

https://www.fnirsi.com/pages/software-downloads

## Credits

This application uses the [CFNReader](https://github.com/RobThree/CFNReader) library by [RobThree](https://github.com/RobThree) for parsing CFN files.

## License

MIT
