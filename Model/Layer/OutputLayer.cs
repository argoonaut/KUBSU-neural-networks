﻿namespace neural_networks_kubsu.NeuralNetwork.Layer.OutputLayer
{
    public class OutputLayer : HiddenLayer.HiddenLayer
    {
        private readonly double[] _result;
        
        public double[] Result
        {
            get
            {
                for (var i = 0; i < Neurons.Length; i++)
                {
                    _result[i] = Neurons[i].ActivationValue;
                }
                return _result;
            }
        }

        public OutputLayer(int units) : base(units)
        {
            _result = new double[units];
        }

        public void ComputeDelta(double[] expectedData)
        {
            for (var i = 0; i < Neurons.Length; i++)
            {
                var errorValue = expectedData[i] - Neurons[i].ActivationValue;
                Neurons[i].Delta = Neurons[i].DerivativeValue * errorValue;
            }
        }
    }
}