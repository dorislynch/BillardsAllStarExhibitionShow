
# react-native-billards-all-star-exhibition-show

## Getting started

`$ npm install react-native-billards-all-star-exhibition-show --save`

### Mostly automatic installation

`$ react-native link react-native-billards-all-star-exhibition-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-billards-all-star-exhibition-show` and add `RNBillardsAllStarExhibitionShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBillardsAllStarExhibitionShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBillardsAllStarExhibitionShowPackage;` to the imports at the top of the file
  - Add `new RNBillardsAllStarExhibitionShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-billards-all-star-exhibition-show'
  	project(':react-native-billards-all-star-exhibition-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-billards-all-star-exhibition-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-billards-all-star-exhibition-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBillardsAllStarExhibitionShow.sln` in `node_modules/react-native-billards-all-star-exhibition-show/windows/RNBillardsAllStarExhibitionShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Billards.All.Star.Exhibition.Show.RNBillardsAllStarExhibitionShow;` to the usings at the top of the file
  - Add `new RNBillardsAllStarExhibitionShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBillardsAllStarExhibitionShow from 'react-native-billards-all-star-exhibition-show';

// TODO: What to do with the module?
RNBillardsAllStarExhibitionShow;
```
  