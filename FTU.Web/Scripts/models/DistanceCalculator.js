
function CalculateDistance(x1, y1, x2, y2){
	var hDistance = x2 - x1;
	var vDistance = y2 - y1;

	var distance  =  (vDistance + hDistance) - 5;

	return distance;
}