done =False
counter = 0
while done == False:
	counter = counter + 20
	for x in xrange(1,20):
		if counter % x == 0:
			done = True
		else:
			done = False
			break
		print (counter)
