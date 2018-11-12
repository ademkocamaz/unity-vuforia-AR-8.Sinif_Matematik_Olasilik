 var goingUp = true;
 var rotationSpeed = 2000;
 var moveSpeed = 40;
 var maxHeight = 100;
 var landHeight = 0;
 var hasFlipped = false;
 var flip = false;
 var isHeads = true;
 
 function Update(){
 
 if(flip) //when you want to flip, simply set flip = true
 {
 transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed); //spin
 if(goingUp)
 {
 if(transform.position.y < maxHeight-1) // haven't reached apex yet
 transform.Translate(Vector3.up * Time.deltaTime * moveSpeed,Space.World); // so move upward
 else
 goingUp = false;// reached top of flip
 }
 
 if(!goingUp) // go back down
 {
 if(transform.position.y > landHeight) // haven't reached ground yet
 transform.Translate(-Vector3.up * Time.deltaTime * moveSpeed,Space.World); // so move down
 else
 flip = false;  // finish flip
 hasFlipped = true; // so we can differentiate from before the flip started
 }
 }
 
 if(!flip && hasFlipped)
 {
 var tempRot = transform.rotation; //store our rotation
 
 if(isHeads) // if heads, 
 tempRot.x = 0; // set x rotation of our stored value to face up
 else
 tempRot.x = 180; // else opposite side up
 
 transform.rotation = tempRot; // replace our current rotation with new rotation
 
 }
 }