# Database-LINQ-demo
This is a C# application built for a class project that uses LINQ to track customer's inventory parts over multiple data sets.  

## Description
The ABC Manufacturing Company wants to keep track of outstanding shipments of the many parts that they order from their various parts suppliers. A shipment consists of a quantity of a part that has been ordered from a supplier. 
Each part has a unique part# and is ordered from one of several suppliers located in various cities. There might be several shipments for each type of part.
Each supplier has a name and a supplier# and a rating or status code. There might be several outstanding shipments for a particular part from different suppliers; however, new shipments for a part are never requested from a supplier if there is an outstanding shipment for that part from that supplier. A supplier can supply many different parts and several suppliers can supply a part.
Some of the information that is needed for parts is the color, name, weight of a part and city where the part is located.

**Program Functions**
1. Display the content of each of the arrays: suppliers, parts, and shipment.
2. Prompt user for a Color input, and use that color to Query and display all cities that a part with such a color is located in (show each city name once).
3. Query suppliers data and display only the suppliers names in ascending order.
4. Query and display the orders for a particular supplier. That is, if you type in a S# or SN, your program displays a list of its corresponding PName  (part name) and  Qty (quantity).



## Getting Started
Download or clone the repository. 

## Description of Project Files
Program.cs- This class is the main entry point for the program. 

## Testing
Unit tests were performed on a variety of edge cases for shipments and suppliers 

## Demonstration
Here is an example of the application running.
![alt text][logo]

[logo]: https://github.com/ChrisToplikar/Database-LINQ-demo/blob/master/LINQ%20demo.JPG?raw=true
 "Application Demo"
