﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user

            Console.ReadKey();
        }
    }

   
    /// The 'Product' abstract class

    abstract class Page
    {
    }

    /// A 'ConcreteProduct' class

    class SkillsPage : Page
    {
    }

   
    /// A 'ConcreteProduct' class

    class EducationPage : Page
    {
    }

    /// A 'ConcreteProduct' class


    class ExperiencePage : Page
    {
    }

    /// A 'ConcreteProduct' class

    class IntroductionPage : Page
    {
    }

    /// A 'ConcreteProduct' class

    class ResultsPage : Page
    {
    }

    /// A 'ConcreteProduct' class

    class ConclusionPage : Page
    {
    }

    /// A 'ConcreteProduct' class

    class SummaryPage : Page
    {
    }

    /// A 'ConcreteProduct' class

    class BibliographyPage : Page
    {
    }

    /// The 'Creator' abstract class

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method

        public abstract void CreatePages();
    }

    /// A 'ConcreteCreator' class

    class Resume : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    /// A 'ConcreteCreator' class

    class Report : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
