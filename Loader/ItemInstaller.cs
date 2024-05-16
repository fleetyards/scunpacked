using System;
using System.Collections.Generic;
using System.Linq;
using scdb.Xml.Entities;

namespace Loader
{
	public class ItemInstaller
	{
		EntityService entitySvc;
		LoadoutLoader loadoutLoader;
		ItemBuilder itemBuilder;

		public ItemInstaller(EntityService entitySvc, LoadoutLoader loadoutLoader, ItemBuilder itemBuilder)
		{
			this.entitySvc = entitySvc;
			this.loadoutLoader = loadoutLoader;
			this.itemBuilder = itemBuilder;
		}

		public void InstallLoadout(StandardisedItem item, List<StandardisedLoadoutEntry> loadout)
		{
			foreach (var port in item.Ports)
			{
				InstallLoadout(port, loadout);
			}
		}

		public void InstallLoadout(EntityClassDefinition item, List<StandardisedLoadoutEntry> loadout)
		{
			if (item?.Components?.SItemPortContainerComponentParams?.Ports == null)
			{
				return;
			}

			foreach (var port in item.Components?.SItemPortContainerComponentParams?.Ports)
			{
				InstallLoadout(port, loadout);
			}
		}

		public void InstallLoadout(List<StandardisedPart> parts, List<StandardisedLoadoutEntry> loadout)
		{
			foreach (var part in parts)
			{
				InstallLoadout(part, loadout);
			}
		}

		public void InstallLoadout(StandardisedPart part, List<StandardisedLoadoutEntry> loadout)
		{
			if (part.Port != null) InstallLoadout(part.Port, loadout);
			InstallLoadout(part.Parts, loadout);
		}

		public void InstallLoadout(SItemPortDef port, List<StandardisedLoadoutEntry> loadout)
		{
			var loadoutEntry = FindLoadoutEntry(port.Name, loadout);

			if (!String.IsNullOrEmpty(loadoutEntry?.ClassName))
			{
				var item = entitySvc.GetByClassName(loadoutEntry.ClassName);

				if (item == null) return;

				port.EquippedItemUuid = item.__ref;
			}
			else if (!String.IsNullOrEmpty(loadoutEntry?.ClassReference))
			{
				port.EquippedItemUuid = loadoutEntry?.ClassReference;
			}
		}

		public void InstallLoadout(List<StandardisedItemPort> ports, List<StandardisedLoadoutEntry> loadout)
		{
			foreach (var port in ports)
			{
				InstallLoadout(port, loadout);
			}
		}

		public void InstallLoadout(StandardisedItemPort port, List<StandardisedLoadoutEntry> loadout)
		{
			var loadoutEntry = FindLoadoutEntry(port.PortName, loadout);
			if (!String.IsNullOrEmpty(loadoutEntry?.ClassName))
			{
				port.Loadout = loadoutEntry.ClassName;
				var item = entitySvc.GetByClassName(loadoutEntry.ClassName);

				if (item == null) return;

				var standardisedItem = itemBuilder.BuildItem(item);

				port.InstalledItem = standardisedItem;

				// Update the loadout with anything this item brings with it
				var newLoadout = loadoutLoader.Load(item);
				loadoutEntry.Entries.AddRange(newLoadout);

				InstallLoadout(standardisedItem.Ports, loadoutEntry.Entries);
			}
			else if (!String.IsNullOrEmpty(loadoutEntry?.ClassReference))
			{
				var item = entitySvc.GetByReference(loadoutEntry.ClassReference);

				if (item == null) return;

				if (!entitySvc.referenceToClassNameMap.ContainsKey(loadoutEntry.ClassReference)) return;

				port.Loadout = entitySvc.referenceToClassNameMap[loadoutEntry.ClassReference];

				var standardisedItem = itemBuilder.BuildItem(item);

				port.InstalledItem = standardisedItem;

				// Update the loadout with anything this item brings with it
				var newLoadout = loadoutLoader.Load(item);
				loadoutEntry.Entries.AddRange(newLoadout);

				InstallLoadout(standardisedItem.Ports, loadoutEntry.Entries);
			}
		}

		StandardisedLoadoutEntry FindLoadoutEntry(string portName, List<StandardisedLoadoutEntry> loadout)
		{
			var loadoutEntry = loadout.FirstOrDefault(x => String.Equals(x.PortName, portName, StringComparison.OrdinalIgnoreCase));
			return loadoutEntry;
		}
	}
}
