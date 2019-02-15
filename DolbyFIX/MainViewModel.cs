using Dolby.Interop;
using Dolby.Pcee.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace Dolby.Pcee.Selector
{
	public class MainViewModel : DolbyViewModel
	{
		public MainViewModel(IDolbyGateway gateway): base(gateway)
		{

        }

		protected override void RefreshProfiles()
		{
			if (!string.IsNullOrEmpty(base.Gateway.DolbyProfileEditorCommand))
			{
				List<Dolby.Interop.ProfileInfo> list = (from x in base.Gateway.GetProfiles()
				where DolbyViewModel.IsCustomProfile(x.Id)
				select x).ToList();
				foreach (Dolby.Interop.ProfileInfo item in list)
				{
					ReadOnlyObservableCollection<Dolby.Pcee.Common.ProfileInfo> customProfiles = base.Profiles.CustomProfiles;
					Func<Dolby.Pcee.Common.ProfileInfo, bool> predicate = (Dolby.Pcee.Common.ProfileInfo p) => p.Id == item.Id;
					if (customProfiles.Any(predicate))
					{
						base.Profiles.CustomProfiles.First((Dolby.Pcee.Common.ProfileInfo p) => p.Id == item.Id).Name = item.Name;
					}
					else
					{
						base.Profiles.Add(new Dolby.Pcee.Common.ProfileInfo(item.Id)
						{
							Name = item.Name
						});
					}
				}
				foreach (int item2 in (from x in base.Profiles.CustomProfiles
				select x.Id).Except(from x in list
				select x.Id).ToList())
				{
					base.Profiles.Remove(item2);
				}
			}
		}
	}
}
