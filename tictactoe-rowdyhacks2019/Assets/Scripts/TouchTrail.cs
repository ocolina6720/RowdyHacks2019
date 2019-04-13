using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrail : MonoBehaviour
{
    [SerializeField] TrailRenderer trailPrefab;
    TrailRenderer currentTrail;
    // Update is called once per frame
    void Update(){
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
            Ray nRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(nRay, out rayDistance))
            {
                this.transform.position = nRay.GetPoint(rayDistance);
                if (currentTrail == null)
                {
                    currentTrail = Instantiate(trailPrefab, nRay.GetPoint(rayDistance), Quaternion.identity);
                }
                else
                {
                    currentTrail.transform.position = nRay.GetPoint(rayDistance);
                }
            }
        }
        else {
            if (currentTrail != null) {
                currentTrail = null;
            }
        }
    }
}
