using System;
using System.Collections.Generic;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create CristmasTree and two Decorators
            CristmasTree c = new CristmasTree();
            GarlandDecorator d1 = new GarlandDecorator();
            PresentDecorator d2 = new PresentDecorator();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.SetUpTree();

            // Wait for user
            Console.Read();
        }
    }
    // "Tree"
    abstract class Tree
    {
        public abstract void SetUpTree();
    }

    // "CristmasTree"
    class CristmasTree : Tree
    {
        public override void SetUpTree()
        {
            Console.WriteLine("This is christmastree.");
        }
    }
    // "TreeDecorator"
    abstract class TreeDecorator : Tree
    {
        protected Tree component;

        public void SetComponent(Tree component)
        {
            this.component = component;
        }
        public override void SetUpTree()
        {
            if (component != null)
            {
                component.SetUpTree();
            }
        }
    }

    // "GarlandDecorator"
    class GarlandDecorator : TreeDecorator
    {
        private bool _isTreeShining;
        public override void SetUpTree()
        {
            base.SetUpTree();
            Console.WriteLine("Tree was decorated with garland");
            _isTreeShining = true;
            Shine();
        }
        void Shine()
        {
            Console.WriteLine("Tree is shining!");
        }
    }

    // "PresentDecorator" 
    class PresentDecorator : TreeDecorator
    {
        private List<String> _presents = new List<string>();
        public override void SetUpTree()
        {
            base.SetUpTree();
            _presents.Add("Helicopter");
            _presents.Add("Cake");
            Console.WriteLine("Presents were added: ");
            foreach (String s in _presents)
            {
                Console.WriteLine(s);
            }
        }
    }
}
