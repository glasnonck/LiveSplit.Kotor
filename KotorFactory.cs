using System.Reflection;
using LiveSplit.Kotor;
using LiveSplit.UI.Components;
using System;
using LiveSplit.Model;

[assembly: ComponentFactory(typeof(KotorFactory))]

namespace LiveSplit.Kotor
{
    class KotorFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Kotor"; }
        }

        public string Description
        {
            get { return "Automates load removal for Star Wars: Knights of the Old Republic."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new KotorComponent(state);
        }

        public string UpdateName
        {
            get { return this.ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/glasnonck/LiveSplit.Kotor/master/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.Kotor.xml"; }
        }
    }
}
