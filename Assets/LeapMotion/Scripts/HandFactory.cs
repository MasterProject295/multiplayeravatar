using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Leap;

namespace Leap.Unity {
public abstract class HandFactory : NetworkBehaviour {
    
    /** Creates a hand representation object that can receive updates from LeapHandController
     * @param hand The hand for which a representation is to be generated.
     * @returns hand representation for the given hand
    */
     public abstract HandRepresentation MakeHandRepresentation(Hand hand, ModelType modelType);
  }
}
