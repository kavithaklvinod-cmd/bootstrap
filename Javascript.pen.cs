var option=prompt("please select your choice: \n 1.Area of Rectangle: \n 2.Area of Triangle \n 3.Area of Circle \n 4.Area of parallelogram")

if (option=="1"){

var l=prompt("enter the length");

var b=prompt("enter the breadth");

var result=l*b;

alert("The area is " +result)

}

if (option=="2"){

var b=prompt("enter the base");

var h=prompt("enter the height");

var result=(b*h)/2;

alert("The area is " +result)

}

if (option=="3"){

var r=prompt("enter the base");

var result=3.14*r*r;

alert("The area is " +result)

}

if (option=="4"){

var b=prompt("enter the base");

var h=prompt("enter the height");

var result=(b*h);

alert("The area is " +result)

}