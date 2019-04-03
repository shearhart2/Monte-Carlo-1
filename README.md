## Monte Carlo questions - Brent Shearhart


### Input -> Result 

- 10 -> Estimated Pi: 3.6 
	0.458407346410207 off from Math.Pi

- 100 -> Estimated Pi: 3.04
	0.101592653589793 off from Math.Pi

- 1000 -> Estimated Pi: 3.156
	0.014407346410207 off from Math.Pi

- 10000 -> Estimated Pi: 3.146
	0.00440734641020679 off from Math.Pi
	
1. Why do we multiply the value from step 5 above by 4?
Answer: We are only operating on 1/4 of the circle, we multiply by 4 to equate the estimation with the entire circle.

2. What do you observe in the output when running your program with parameters of increasing size?
Answer: As you increase the number, the results get closer to the value of Math.PI.

3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
Answer: No, because the points are being plotted randomly. Sometimes there will be more inside the the "valid point" area, and other times there won't.

4. 	Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
Answer: 
100000000
Number of valid points is 78541217
Estimated Pi: 3.14164868
This estimate is 5.60264102067443E-05 off from Math.Pi


5. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
Answer: How to calculate if an atoic bomb will explode or not(WWII)
