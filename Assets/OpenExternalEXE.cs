using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class OpenExternalEXE : MonoBehaviour {

   // public string filename;

    public void openFile(string filename) {
        Process.Start(filename);
    }
}
