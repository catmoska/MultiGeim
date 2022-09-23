
def xesh(x):
    r = hex(x)
    if len(r)==3:
        return "0"+r[2]
    return r[2:4]

u =0
for r in range(6):
    for g in range(6):
        for b in range(6):
            u+=1
            print(f"{u}   \t {xesh(r*51)}{xesh(g*51)}{xesh(b*51)}")



r = int("ff",16)/51
g = int("ff",16)/51
b = int("66",16)/51

print(((r*36)+(g*6)+(b)))


