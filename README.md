## Xamarin.iOS bindings library for [PKHUD](https://github.com/pkluz/PKHUD) swift library
Thanks to [Lucas Teixeira](https://github.com/Flash3001) for helping and for the [Xamarin.Swift3.Support](https://github.com/Flash3001/Xamarin.Swift3.Support) packages.
## Usage Example
```cs
PKHUD.SharedHUD.DimsBackground = false;
PKHUD.PKHUD.SharedHUD.ContentView = new Xamarin.PKHUD.PKHUDSuccessView(null, null);
PKHUD.PKHUD.SharedHUD.Show();
PKHUD.PKHUD.SharedHUD.HideAfterDelay(10, _ => { });
```
```cs
var pKHUD = new PKHUD
{
	DimsBackground = false,
	ContentView = new PKHUDProgressView("Title", "Subtitle")
};
pKHUD.Show();
pKHUD.HideAfterDelay(10, _ => { });
```