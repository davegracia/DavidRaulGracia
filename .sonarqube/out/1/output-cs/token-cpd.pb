•
JC:\Users\gteam\source\repos\DavidGracia\ClienteWebServiceImperial\Form1.cs
	namespace 	%
ClienteWebServiceImperial
 #
{ 
public		 

partial		 
class		 
Form1		 
:		  
Form		! %
{

 
readonly (
WebServiceImperialSoapClient -
_clienteImperial. >
=? @
newA D(
WebServiceImperialSoapClientE a
(a b
)b c
;c d
private 
static 
readonly 
log4net  '
.' (
ILog( ,
Log- 0
=1 2
log4net3 :
.: ;

LogManager; E
.E F
	GetLoggerF O
(O P
SystemP V
.V W

ReflectionW a
.a b

MethodBaseb l
.l m
GetCurrentMethodm }
(} ~
)~ 
.	 Ä
DeclaringType
Ä ç
)
ç é
;
é è
public 
Form1 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
button1_Click "
(" #
object# )
sender* 0
,0 1
	EventArgs2 ;
e< =
)= >
{ 	
if 
( 
! 
String 
. 
IsNullOrWhiteSpace *
(* +
textBox1+ 3
.3 4
Text4 8
)8 9
&&: <
!= >
String> D
.D E
IsNullOrWhiteSpaceE W
(W X
textBox2X `
.` a
Texta e
)e f
)f g
{ 
var 
datos 
= 
new 
List  $
<$ %
string% +
>+ ,
{- .
textBox1/ 7
.7 8
Text8 <
,< =
textBox2> F
.F G
TextG K
}L M
.M N
ToListN T
(T U
)U V
;V W
ArrayOfString 
identificacion ,
=- .
new/ 2
ArrayOfString3 @
(@ A
)A B
;B C
_clienteImperial  
.  !
AdjuntarRebelde! 0
(0 1
textBox11 9
.9 :
Text: >
)> ?
;? @
_clienteImperial  
.  !
AdjuntarPlaneta! 0
(0 1
textBox21 9
.9 :
Text: >
)> ?
;? @
identificacion 
. 
AddRange '
(' (
datos( -
)- .
;. /
_clienteImperial!!  
.!!  !"
AdjuntarIdentificacion!!! 7
(!!7 8
identificacion!!8 F
)!!F G
;!!G H
}"" 
else## 
{$$ 
Log%% 
.%% 
Error%% 
(%% 
$str%% G
+%%H I
DateTime%%J R
.%%R S
Now%%S V
)%%V W
;%%W X

MessageBox&& 
.&& 
Show&& 
(&&  
$str&&  S
)&&S T
;&&T U
}'' 
}(( 	
})) 
}** ì
LC:\Users\gteam\source\repos\DavidGracia\ClienteWebServiceImperial\Program.cs
	namespace 	%
ClienteWebServiceImperial
 #
{ 
static 

class 
Program 
{ 
private 
static 
readonly 
log4net  '
.' (
ILog( ,
Log- 0
=1 2
log4net3 :
.: ;

LogManager; E
.E F
	GetLoggerF O
(O P
SystemP V
.V W

ReflectionW a
.a b

MethodBaseb l
.l m
GetCurrentMethodm }
(} ~
)~ 
.	 Ä
DeclaringType
Ä ç
)
ç é
;
é è
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
Form1  %
(% &
)& '
)' (
;( )
Log 
. 
Info 
( 
$str 4
+5 6
DateTime7 ?
.? @
Now@ C
)C D
;D E
} 	
} 
} É
\C:\Users\gteam\source\repos\DavidGracia\ClienteWebServiceImperial\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str 4
)4 5
]5 6
[ 
assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
]" #
[		 
assembly		 	
:			 
!
AssemblyConfiguration		  
(		  !
$str		! #
)		# $
]		$ %
[

 
assembly

 	
:

	 

AssemblyCompany

 
(

 
$str

 $
)

$ %
]

% &
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 6
)6 7
]7 8
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 7
)7 8
]8 9
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
["" 
assembly"" 	
:""	 

AssemblyVersion"" 
("" 
$str"" $
)""$ %
]""% &
[## 
assembly## 	
:##	 

AssemblyFileVersion## 
(## 
$str## (
)##( )
]##) *
[$$ 
assembly$$ 	
:$$	 

log4net$$ 
.$$ 
Config$$ 
.$$ 
XmlConfigurator$$ )
($$) *

ConfigFile$$* 4
=$$5 6
$str$$7 G
)$$G H
]$$H I