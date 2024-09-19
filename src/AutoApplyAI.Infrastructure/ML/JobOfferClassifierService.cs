using AutoApplyAI.Domain.Entities;
using AutoApplyAI.Domain.Interfaces;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApplyAI.Infrastructure.ML
{
    public class JobOfferClassifierService : IJobOfferClassifierService
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;

        public JobOfferClassifierService()
        {
            _mlContext = new MLContext();
            _model = LoadModel();
        }

        private ITransformer LoadModel()
        {
            // Load the pre-trained ML.NET model
            string modelPath = "path_to_model/JobOfferClassifier.zip";
            return _mlContext.Model.Load(modelPath, out _);
        }

        public bool IsRelevantJob(JobOffer jobOffer, string candidateSkills)
        {
            // Create input data for prediction
            var input = new JobOfferInput
            {
                JobTitle = jobOffer.JobTitle,
                JobDescription = jobOffer.JobDescription,
                RequiredSkills = jobOffer.RequiredSkills
            };

            // Predict relevance using the ML.NET model
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<JobOfferInput, JobOfferPrediction>(_model);
            var prediction = predictionEngine.Predict(input);

            return prediction.IsRelevant;
        }
    }
}
