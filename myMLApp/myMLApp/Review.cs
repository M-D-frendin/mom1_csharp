using MyMLApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMLApp
{
    internal class Review
    {

        //private properties
        private string _text = string.Empty; 
        private bool _isPositive = false; 

        //public properties
        public string Text
        {
            get => _text; 
            set {
                _text = value; 

                //when property Text is set, determine sentiment
                this._determineSentiment(); 
            }
        }
    
        public bool IsPositive 
        {
            get {
                return this._isPositive; 
            }
        }

        //constructor, takes a review text as parameter
        public Review(string input)
        {
            this.Text = input;
        }

        //determine sentiment from review text, is automatically called when Text property has been set
        private void _determineSentiment()
        {
            //populate a model input structure with the review text
            var modelData = new SentimentModel.ModelInput() 
            {
                Col0 = this.Text 
            };

            //make a prediction, returns 1 if "positive", 0 if "negative"
            SentimentModel.ModelOutput prediction = SentimentModel.Predict(modelData); 

            if (prediction.PredictedLabel == 1) {
                this._isPositive = true; 
            } else {
                this._isPositive = false;
            }
        }

    }
}
