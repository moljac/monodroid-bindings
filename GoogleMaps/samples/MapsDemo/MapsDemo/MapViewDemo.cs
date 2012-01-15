/*
 * Copyright (C) 2007 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Android.App;
using Android.Content;
using Android.OS;
using Android.GoogleMaps;

namespace MonoDroid.Samples.MapsDemo
{
	// This demonstrates creating a Map based Activity.
	[Activity (Name = "com.example.monodroid.googleapis.maps.MapViewDemo", Label = "MapView")]
	[IntentFilter (new[] { Intent.ActionMain }, Categories = new string[] { Intent.CategorySampleCode })]
	public class MapViewDemo : MapActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.mapview);
		}

		protected override bool IsRouteDisplayed {
			get { return false; }
		}
	}
}
