done =False
counter = 0
while done == False:
	for x in xrange(1,20):
		if done % x == 0:
			done = True
		else:
			done = False
			break;
print (counter)