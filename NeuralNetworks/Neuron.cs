﻿using System.Collections;
using System.Collections.Generic;

namespace NeuralNetworks
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float value;
        public List<Neuron> In, Out;
        //public void ConnectTo(Neuron other)
        //{
        //    Out.Add(other);
        //    other.In.Add(this);
        //}

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}
