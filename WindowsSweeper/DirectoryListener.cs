using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsSweeper {
	/* Class that is used to listen to changes in a specific directory */
	public class DirectoryListener {
		private static int current_id = 0;

		private string path;
		private Thread worker;
		private int id;

		public DirectoryListener (string path) {
			this.path = path;
			id = current_id++;

			worker = new Thread ( this.listen );
			worker.Start ();
		}

		protected void listen () {
			Console.WriteLine ("Worker {0} has started working.", id);


			Console.WriteLine ( "Worker {0} has finished working." , id );
			Thread.CurrentThread.Join ();
		}
	}
}
