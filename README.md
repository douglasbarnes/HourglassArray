# HourglassArray
A O(n) solution to the hackerrank 2D Array - DS challenge. 

Firstly, the brute-force solution would be to iterate through the array making hour glass shapes. This isn't great, and a general solution can definitely be applied to the problem.

My first attempt to solve the problem was to use a graph colouring proof on a 6x6 map.

![Model](https://i.imgur.com/nzugoBq.png)

This got a little hectic, so I decided to use numbers to describe the hourglasses.
For example glass N looks like,
  n  n  n
     n
  n  n  n
 , where N is an integer between 0 and 19, as 19 distinct hourglasses can overlap on the map.

 ![Model](https://i.imgur.com/m7uag0y.png)
 
 The difference between blue and black numbers is to distinguish 1 and 0 from 10. 
 Using this, I could create a map in code to represent this. Then, an array of integers could be used alongside this map, such that the numbers in the map represent the indicies
 of the hourglasses. This map has to be a 3 row jagged array, because values need to be stored for each square. I could not find an effective way to determine which glasses were
 present on each square mathematically. 
 After the map has been made, it is as simple as iterating through the rows and columns of the input, then adding the value at the position in the input to onto the value of all 
 the present hourglasses(which can be found by accessing the map at the same coordinate as the value of the input was located).
 
 At this point, the problem is solved, but I decided to look further into the hourglass idea. An O(n) solution is also possible for the sum of all hourglass values. This can be
 modelled a little better with a graph colouring proof.
 
 ![Model](https://i.imgur.com/VfXLzjc.png)
 
 Each number here is the total count of hourglasses present on each spot(therefore a similar approach to before can be taken). To code this, you could iterate through the input and
 multiply each value of the input by the value at the same coordinate on the (new) map. 
 I tried to find a further simplification, because the map can get quite messy when implemented into a program
 
 ![Model](https://i.imgur.com/2sNAft9.png)
 
 I could not find a general formula for the above. The function would take the X coordinate and Y coordinate and produce the value. I tried combining piecewise functions as there is
 a recursive function downwards adding 1 for every 2n, then going across the middle there is what appears to be a fibonacci sequence added on top that is added on to the downwards
 recusive function(fibonacci is also a recursive function). This is most likely a coincidence, but still interesting. With no way to generalise the map, I don't see a better solution
 than this.
