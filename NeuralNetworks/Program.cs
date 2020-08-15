using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks
{
    class Program
    {
        static void Main(string[] args)
        {
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();

            //neuron1.In = new List<Neuron>();
            //neuron1.Out = new List<Neuron>();

            //neuron1.In.Add(new Neuron());
            //neuron1.Out.Add(new Neuron());

            //neuron2.In = new List<Neuron>();
            //neuron2.Out = new List<Neuron>();

            //neuron2.In.Add(new Neuron());
            //neuron2.Out.Add(new Neuron());

            neuron1.ConnectTo(neuron2);

            var layer1 = new NeuronLayer();
            var layer2 = new NeuronLayer();
 

            neuron1.ConnectTo(layer1);
            layer1.ConnectTo(layer2);

        }
    }

}
