talan = 600851475143 
deiling = 2 #prímtala sem er verið að deila með
prime = True

while talan != 1:
    if talan % deiling == 0:
    	for x in xrange(2, (deiling-1)):
    		if deiling % x == 0:
    			prime = False
    	if prime == True:
    		talan = talan / deiling
    	else
    		prime = True
print deiling