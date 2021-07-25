using Propmotions.Core;
using System.Collections.Generic;

namespace Promotions.UnitTests
{
    public class KeywordsBuilder
    {
        private Keyword _keyword = new Keyword();

        public KeywordsBuilder Id(int id)
        {
            _keyword.Id = id;
            return this;
        }

        public KeywordsBuilder Name(string name)
        {
            _keyword.Name = name;
            return this;
        }

        public KeywordsBuilder Description(string description)
        {
            _keyword.Description = description;
            return this;
        }

        public KeywordsBuilder WithDefaultValues()
        {
            _keyword = new Keyword() { Name = "Test Name", Description = "Test Description" };
            return this;
        }

        public KeywordsBuilder WithId()
        {
            _keyword = new Keyword() {Id=100,  Name = "Test Name", Description = "Test Description" };
            return this;
        }

        public KeywordsBuilder WithDefaultValuesAndDocuments()
        {
            _keyword = new Keyword() { Name = "Test Name", Description = "Test Description"};

            _keyword.DocumemtMappings = new List<KeywordDocumentMapping>()
            {
                new KeywordDocumentMapping(){
                    DocumentId = 1                   
                },
                new KeywordDocumentMapping(){
                 DocumentId = 2
                    }
            };

            return this;
        }

        public KeywordsBuilder WithDocuments()
        {
            _keyword.DocumemtMappings = new List<KeywordDocumentMapping>()
            {
                new KeywordDocumentMapping(){
                    DocumentId = 1,
                    KeywordId=100
                },
                new KeywordDocumentMapping(){
                 DocumentId = 2,
                 KeywordId=100
                    }
            };

            return this;
        }


        public Keyword Build() => _keyword;
    }
}
