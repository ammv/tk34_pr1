#Решает систему уравнений методом гаусса
 
def printm(matrix):
    for i in matrix:
        print(i)
 
def mul_(s, n):
    new_s = []
    for i in s:
        new_s.append(i*n)
    return new_s
    
def div_(s,n):
    new_s = []
    for i in s:
        new_s.append(round(i/n,2))
    return new_s
    
def add_(s1,s2):
    new_s = []
    for i in range(len(s1)):
        new_s.append(s1[i]+s2[i])
    return new_s

def find_x(matrix):
    s = [matrix[-1][-1]]
    l = len(matrix[0])-1
    x = ''.join(f'x{i}='+'{}\n' for i in range(1,len(matrix)+1))
    
    for i in matrix[-2::-1]:
        s.append(i[-1] + -1*sum(i*j for i,j in zip(i[l-len(s):l], s[::-1])))
    
    return x.format(*s[::-1]), matrix
 
def solve_sys_gauss_method(matrix):
    lm = len(matrix)
    if 1 in [matrix[i][0] for i in range(lm)]:
        matrix = sorted(matrix,key=lambda x: x[0])

    for i in range(lm-1):
        for j in range(i+1, lm):
            matrix[j] = add_(
                            mul_(
                                matrix[i],
                                -1*matrix[j][i]),
                            matrix[j])
        matrix[i+1] = div_(matrix[i+1], matrix[i+1][i+1])

    solution = find_x(matrix)
    return solution
   
matrix = [
    [1,-1,-5],
    [2, 1, -7],
]

matrix2 = [
    [3,2,-5,-1],
    [2,-1,3,13],
    [1,2,-1,9],
]

matrix3 = [
    [1,2,3,1],
    [2,-1,2,6],
    [1,1,5,-1]
]

matrix4 = [
    [2,1,-1,0],
    [3,4,6,0],
    [1,0,1,1],
]

matrix5 = [
    [2,5,4,1,20],
    [1,3,2,1,11],
    [2,10,9,7,40],
    [3,8,9,2,37],
]

'''
[1,2,-1,9]
[2,-1,3,13]
[3,2,-5,-1]
'''

 
f = solve_sys_gauss_method
result = f(matrix5)
print(result[0])
printm(result[1])