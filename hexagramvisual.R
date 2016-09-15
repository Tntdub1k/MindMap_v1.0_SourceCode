library(rgl)
x <- c(-1,1,1,-1)
y <- c(-1,-1,1,1)
z <- c(-1,1,1,-1)
reducer = .60

cubes = matrix(nrow = 8 ,ncol = 5)
i = 1

attachinglinescolor = "black"
plot3d(x,y,z,box=false,axes=false)
hi1 = 1
low1 = -1
lowz = 0
hiz = 0

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

text3d(low1,low1,lowz,texts="#48Hexagram")


hi2 = 0.15
low2 = -0.15
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1

segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)

#cube 2

hi1 = 1
low1 = -1
lowz = 1
hiz = 1

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.15
low2 = -0.15
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)

#cube 3

hi1 = .7
low1 = -.7
lowz = 0.05
hiz = 0.05

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.6*reducer
low2 = -0.6*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)

#cube 4

hi1 = .7
low1 = -.7
lowz = .95
hiz = .95

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.6*reducer
low2 = -0.6*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)


#start cube 5

reducer = .60*.85

hi1 = 1.1*reducer
low1 = -1.1*reducer
lowz = .2
hiz = .2

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.90*reducer
low2 = -0.90*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)

#cube 2

hi1 = 1.1*reducer
low1 = -1.1*reducer
lowz = .8
hiz = .8

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.90*reducer
low2 = -0.90*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)




#cube 3

hi1 = 1.05*reducer
low1 = -1.05*reducer
lowz = 0.3
hiz = 0.3

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.95*reducer
low2 = -0.95*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)

#cube 4

hi1 = 1.05*reducer
low1 = -1.05*reducer
lowz = .7
hiz = .7

segments3d(c(low1,hi1),c(low1,low1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,hi1),c(hi1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(low1,low1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)
segments3d(c(hi1,hi1),c(low1,hi1),c(lowz,lowz),col=2,lwd=2)

hi2 = 0.95*reducer
low2 = -0.95*reducer
cubes[i,1] = low1
cubes[i,2] = hi1
cubes[i,3] = low2
cubes[i,4] = hi2
cubes[i,5] = lowz
i = i+1


segments3d(c(low2,hi2),c(low2,low2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,hi2),c(hi2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(low2,low2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)
segments3d(c(hi2,hi2),c(low2,hi2),c(hiz,hiz),col=2,lwd=2)

segments3d(c(low1,low2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(low1,low2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(hi1,hi2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)
segments3d(c(low1,low2),c(hi1,hi2),c(lowz,hiz),col=2,lwd=2)



#connect cubes
segments3d(c(cubes[1,1],cubes[3,1]),c(cubes[1,1],cubes[3,1]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,2],cubes[3,2]),c(cubes[1,2],cubes[3,2]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,3],cubes[3,3]),c(cubes[1,3],cubes[3,3]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,4],cubes[3,4]),c(cubes[1,4],cubes[3,4]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,1],cubes[3,1]),c(cubes[1,2],cubes[3,2]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,4],cubes[3,4]),c(cubes[1,3],cubes[3,3]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,3],cubes[3,3]),c(cubes[1,4],cubes[3,4]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)
segments3d(c(cubes[1,2],cubes[3,2]),c(cubes[1,1],cubes[3,1]),c(cubes[1,5],cubes[3,5]),col="black",lwd=2)

segments3d(c(cubes[1,1],cubes[5,1]),c(cubes[1,1],cubes[5,1]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,2],cubes[5,2]),c(cubes[1,2],cubes[5,2]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,3],cubes[5,3]),c(cubes[1,3],cubes[5,3]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,4],cubes[5,4]),c(cubes[1,4],cubes[5,4]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,1],cubes[5,1]),c(cubes[1,2],cubes[5,2]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,4],cubes[5,4]),c(cubes[1,3],cubes[5,3]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,3],cubes[5,3]),c(cubes[1,4],cubes[5,4]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[1,2],cubes[5,2]),c(cubes[1,1],cubes[5,1]),c(cubes[1,5],cubes[5,5]),col="black",lwd=2)

segments3d(c(cubes[3,1],cubes[5,1]),c(cubes[3,1],cubes[5,1]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,2],cubes[5,2]),c(cubes[3,2],cubes[5,2]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,3],cubes[5,3]),c(cubes[3,3],cubes[5,3]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,4],cubes[5,4]),c(cubes[3,4],cubes[5,4]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,1],cubes[5,1]),c(cubes[3,2],cubes[5,2]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,4],cubes[5,4]),c(cubes[3,3],cubes[5,3]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,3],cubes[5,3]),c(cubes[3,4],cubes[5,4]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)
segments3d(c(cubes[3,2],cubes[5,2]),c(cubes[3,1],cubes[5,1]),c(cubes[3,5],cubes[5,5]),col="black",lwd=2)

segments3d(c(cubes[3,1],cubes[7,1]),c(cubes[3,1],cubes[7,1]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,2],cubes[7,2]),c(cubes[3,2],cubes[7,2]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,3],cubes[7,3]),c(cubes[3,3],cubes[7,3]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,4],cubes[7,4]),c(cubes[3,4],cubes[7,4]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,1],cubes[7,1]),c(cubes[3,2],cubes[7,2]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,4],cubes[7,4]),c(cubes[3,3],cubes[7,3]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,3],cubes[7,3]),c(cubes[3,4],cubes[7,4]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)
segments3d(c(cubes[3,2],cubes[7,2]),c(cubes[3,1],cubes[7,1]),c(cubes[3,5],cubes[7,5]),col="black",lwd=2)

segments3d(c(cubes[2,1],cubes[4,1]),c(cubes[2,1],cubes[4,1]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,2],cubes[4,2]),c(cubes[2,2],cubes[4,2]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,3],cubes[4,3]),c(cubes[2,3],cubes[4,3]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,4],cubes[4,4]),c(cubes[2,4],cubes[4,4]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,1],cubes[4,1]),c(cubes[2,2],cubes[4,2]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,4],cubes[4,4]),c(cubes[2,3],cubes[4,3]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,3],cubes[4,3]),c(cubes[2,4],cubes[4,4]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[2,2],cubes[4,2]),c(cubes[2,1],cubes[4,1]),c(cubes[2,5],cubes[4,5]),col="black",lwd=2)

segments3d(c(cubes[2,1],cubes[6,1]),c(cubes[2,1],cubes[6,1]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,2],cubes[6,2]),c(cubes[2,2],cubes[6,2]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,3],cubes[6,3]),c(cubes[2,3],cubes[6,3]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,4],cubes[6,4]),c(cubes[2,4],cubes[6,4]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,1],cubes[6,1]),c(cubes[2,2],cubes[6,2]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,4],cubes[6,4]),c(cubes[2,3],cubes[6,3]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,3],cubes[6,3]),c(cubes[2,4],cubes[6,4]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[2,2],cubes[6,2]),c(cubes[2,1],cubes[6,1]),c(cubes[2,5],cubes[6,5]),col="black",lwd=2)

segments3d(c(cubes[4,1],cubes[6,1]),c(cubes[4,1],cubes[6,1]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,2],cubes[6,2]),c(cubes[4,2],cubes[6,2]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,3],cubes[6,3]),c(cubes[4,3],cubes[6,3]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,4],cubes[6,4]),c(cubes[4,4],cubes[6,4]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,1],cubes[6,1]),c(cubes[4,2],cubes[6,2]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,4],cubes[6,4]),c(cubes[4,3],cubes[6,3]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,3],cubes[6,3]),c(cubes[4,4],cubes[6,4]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[4,2],cubes[6,2]),c(cubes[4,1],cubes[6,1]),c(cubes[4,5],cubes[6,5]),col="black",lwd=2)

segments3d(c(cubes[4,1],cubes[8,1]),c(cubes[4,1],cubes[8,1]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,2],cubes[8,2]),c(cubes[4,2],cubes[8,2]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,3],cubes[8,3]),c(cubes[4,3],cubes[8,3]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,4],cubes[8,4]),c(cubes[4,4],cubes[8,4]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,1],cubes[8,1]),c(cubes[4,2],cubes[8,2]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,4],cubes[8,4]),c(cubes[4,3],cubes[8,3]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,3],cubes[8,3]),c(cubes[4,4],cubes[8,4]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[4,2],cubes[8,2]),c(cubes[4,1],cubes[8,1]),c(cubes[4,5],cubes[8,5]),col="black",lwd=2)

segments3d(c(cubes[1,1],cubes[2,1]),c(cubes[1,1],cubes[2,1]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(cubes[1,2],cubes[2,2]),c(cubes[1,2],cubes[2,2]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(cubes[1,3],cubes[2,3]),c(cubes[1,3],cubes[2,3]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(cubes[1,4],cubes[2,4]),c(cubes[1,4],cubes[2,4]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(-cubes[1,1],-cubes[2,1]),c(cubes[1,1],cubes[2,1]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(-cubes[1,2],-cubes[2,2]),c(cubes[1,2],cubes[2,2]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(-cubes[1,3],-cubes[2,3]),c(cubes[1,3],cubes[2,3]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)
segments3d(c(-cubes[1,4],-cubes[2,4]),c(cubes[1,4],cubes[2,4]),c(cubes[1,5],cubes[2,5]),col="black",lwd=2)

segments3d(c(cubes[3,1],cubes[4,1]),c(cubes[3,1],cubes[4,1]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[3,2],cubes[4,2]),c(cubes[3,2],cubes[4,2]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[3,3],cubes[4,3]),c(cubes[3,3],cubes[4,3]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(cubes[3,4],cubes[4,4]),c(cubes[3,4],cubes[4,4]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(-cubes[3,1],-cubes[4,1]),c(cubes[3,1],cubes[4,1]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(-cubes[3,2],-cubes[4,2]),c(cubes[3,2],cubes[4,2]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(-cubes[3,3],-cubes[4,3]),c(cubes[3,3],cubes[4,3]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)
segments3d(c(-cubes[3,4],-cubes[4,4]),c(cubes[3,4],cubes[4,4]),c(cubes[3,5],cubes[4,5]),col="black",lwd=2)

segments3d(c(cubes[5,1],cubes[6,1]),c(cubes[5,1],cubes[6,1]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[5,2],cubes[6,2]),c(cubes[5,2],cubes[6,2]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[5,3],cubes[6,3]),c(cubes[5,3],cubes[6,3]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(cubes[5,4],cubes[6,4]),c(cubes[5,4],cubes[6,4]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(-cubes[5,1],-cubes[6,1]),c(cubes[5,1],cubes[6,1]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(-cubes[5,2],-cubes[6,2]),c(cubes[5,2],cubes[6,2]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(-cubes[5,3],-cubes[6,3]),c(cubes[5,3],cubes[6,3]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)
segments3d(c(-cubes[5,4],-cubes[6,4]),c(cubes[5,4],cubes[6,4]),c(cubes[5,5],cubes[6,5]),col="black",lwd=2)

segments3d(c(cubes[7,1],cubes[8,1]),c(cubes[7,1],cubes[8,1]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[7,2],cubes[8,2]),c(cubes[7,2],cubes[8,2]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[7,3],cubes[8,3]),c(cubes[7,3],cubes[8,3]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(cubes[7,4],cubes[8,4]),c(cubes[7,4],cubes[8,4]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(-cubes[7,1],-cubes[8,1]),c(cubes[7,1],cubes[8,1]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(-cubes[7,2],-cubes[8,2]),c(cubes[7,2],cubes[8,2]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(-cubes[7,3],-cubes[8,3]),c(cubes[7,3],cubes[8,3]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)
segments3d(c(-cubes[7,4],-cubes[8,4]),c(cubes[7,4],cubes[8,4]),c(cubes[7,5],cubes[8,5]),col="black",lwd=2)


























