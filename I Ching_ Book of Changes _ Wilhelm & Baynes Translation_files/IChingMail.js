
/*
This tool was originally conceived and written by Tim
Williams of http://www.arizona.edu/  The University of
Arizona. The code to randomly generate a different encryption key each
time the tool is used was written by Andrew Moulden of http://www.siteengineering.com/  
Site Engineering
Ltd.  This code is distributed as freeware, provided the authors'
credits etc remain as shown.

Phillip of www.Webcatering.com and Janine of www.Panther-Webworks adapted the code to better meet our needs.  
Please get the original from the site above.
*/

<!--



function Display() {
  coded = unescape("u*%5BAia9FRiM%5BlshlBqrsmjYnrJ")
  codedL = unescape("T7QRA3%20slaRsDAia%20M%5BAj%20jAMl%20Mrg%20")
  codedS = unescape("")
  key = "A;VzP]Bcl1&G=IYStp}yJ47sxRUZ0wFW:n3>(H)uE{MC<_fLdj@!8k5qohgiv$2X,bTeQ*6^O.DN9#?mK-r[a"
  shift=coded.length
  link=""
  linkL=""
  linkS=""
  for (i=0; i<coded.length; i++) {
    if (key.indexOf(coded.charAt(i))==-1) {
      ltr = coded.charAt(i)
      link += (ltr)
    }
    else {     
      ltr = (key.indexOf(coded.charAt(i))-shift+key.length) % key.length
      link += (key.charAt(ltr))
    }
  }
  for (i=0; i<codedL.length; i++) {
    if (key.indexOf(codedL.charAt(i))==-1) {
      ltr = codedL.charAt(i)
      linkL += (ltr)
    }
    else {     
      ltr = (key.indexOf(codedL.charAt(i))-shift+key.length) % key.length
      linkL += (key.charAt(ltr))
    }
  }
  for (i=0; i<codedS.length; i++) {
    if (key.indexOf(codedS.charAt(i))==-1) {
      ltr = codedS.charAt(i)
      linkS += (ltr)
    }
    else {     
      ltr = (key.indexOf(codedS.charAt(i))-shift+key.length) % key.length
      linkS += (key.charAt(ltr))
    }
  }
  document.write(linkL+"&nbsp;<a href='ma"+"ilt"+"o:"+link+linkS+"'><u>"+unescape(link.replace(' ', '&nbsp;')).replace('>', '&gt;').replace('<', '&lt;')+"</u></a>")
	}

//-->