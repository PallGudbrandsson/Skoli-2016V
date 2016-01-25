total = 0
sum = 1
strengur = ""
strengur = str(sum) + ", "
print strengur
strengur = ""
last1 = 2
strengur = str(last1 )+ ", "
total = total + last1
print strengur
strengur = ""
last2 = 3
strengur = str(last2) + ", "
print strengur
strengur = ""

while sum <= 4000000:
    sum = last2 +last1
    strengur = str(sum) + ", "
    print strengur
    strengur = ""
    last1 = last2
    last2 = sum
    if sum % 2 == 0:
    	total = total + sum
print total