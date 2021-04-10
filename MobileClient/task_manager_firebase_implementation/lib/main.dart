import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:intl/intl.dart';
import 'package:table_calendar/table_calendar.dart';
import 'databasecontroller.dart';
import 'classes.dart';
import 'firebaseauth.dart';
import 'timer.dart';
import 'dart:ui';
import 'package:shared_preferences/shared_preferences.dart';
void main() {
  runApp(MyApp());
}
double slidervalue=1.00;
String username;
String password;
List<Users> userlist=[];
List<List<String>> quotes=[["Lost time is never found again","– Benjamin Franklin"]];
Users currentuser;
FirebaseAuth auth= FirebaseAuth.instance;
Future<FirebaseUser> user;
Authservice _auth = Authservice();
List<Color> diffcolor=[Colors.amber,Colors.brown,Colors.cyan,Colors.deepPurple,Colors.deepOrange,Colors.green,Colors.indigo,Colors.indigo,Colors.lightBlue,Colors.lightGreen,Colors.orange,Colors.purple,Colors.red,Colors.teal,Colors.yellow];

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: "Task_manager",
      theme: ThemeData(
        visualDensity: VisualDensity.adaptivePlatformDensity,
        primarySwatch: Colors.blue,
      ),
      home: Welcome(),
    );
  }
}
class Welcome extends StatefulWidget {
  @override
  _WelcomeState createState() => _WelcomeState();
}

class _WelcomeState extends State<Welcome> {
  @override
  void initState(){
    this.setState(() {
      _read();
    });
  }
  _read()async{
  final prefs = await SharedPreferences.getInstance();
  final String keyuser ="username";
  final String keypassword="passwords";
  username=prefs.getString(keyuser)??" ";
  password=prefs.getString(keypassword)??" ";
  changepage();
 }
 void changepage(){
   this.setState(() {
   Navigator.of(context).pop();
   Navigator.push(context,MaterialPageRoute(builder: (context) => Signinpage()));
   });
 }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.grey.shade700,
      body:Container(
        padding: EdgeInsets.only(top:100,right:20,left:20),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.all(Radius.circular(20)),
          gradient: new LinearGradient(
                      colors: [Colors.teal.shade300,Colors.indigo.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
        ),
        child:Align(
          alignment:Alignment.center,
          child:Text(
            "Welcome...",
            style:bigWhiteTitle,
          ),
        ),
      )
    );
  }
}
TextStyle bigWhiteTitle = new TextStyle(
  fontFamily: "Helvetica",
  fontWeight: FontWeight.bold,
  fontSize: 30,
  color: Colors.white 
);

class Registerpage extends StatefulWidget {
  @override
  _RegisterpageState createState() => _RegisterpageState();
}

class _RegisterpageState extends State<Registerpage> {
  final _formkey=GlobalKey<FormState>();
  final controller1 = TextEditingController();
  final controller2 = TextEditingController();
  final controller3= TextEditingController();
  String fasketask="";
  bool validation=false;
  bool checkvalidation(String a,String b,String c,String d){
    for(var i =0;i<userlist.length;i++){
      if(a==userlist[i].username){
        return false;
        }
      }
      if(b!=c){
        return false;
      }
      List<String> temp=[];
      temp.add(d);
      currentuser=Users(a,b,temp);
      currentuser.getid(savenewuser(currentuser));
    return true;
  }
  void changepage(){
    this.setState(() {
      FocusScope.of(context).unfocus();
      Navigator.of(context).pop();
      Navigator.push(context,MaterialPageRoute(builder: (context) => MyHomePage()));
    });

  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.grey.shade700,
      body:Container(
        padding: EdgeInsets.only(top:100,right:20,left:20),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.all(Radius.circular(20)),
          gradient: new LinearGradient(
                      colors: [Colors.teal.shade300,Colors.indigo.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
        ),
        child:Align(
          alignment:Alignment.center,
          child:Form(
          key:_formkey,
          child:Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children:<Widget>[
            Text("Signin",style:smallWhiteTitle),
            TextFormField(
              validator: (val)=>!validation?"Enter proper":null,
              controller: controller1,
              decoration: InputDecoration(
                prefixIcon: Icon(Icons.person,color:Colors.white),
                hintText: "Please enter username here",
                focusColor: Colors.white,
              )
            ),
            TextFormField(
              validator: (val)=>!validation?"Enter proper":null,
              controller:controller2,
              decoration: InputDecoration(
                prefixIcon: Icon(Icons.lock_open,color:Colors.white),
                hintText: "Please enter password here",
                focusColor: Colors.white,
              ),
            ),
            TextFormField(
              validator: (val)=>!validation?"Enter proper":null,
              controller:controller3,
              decoration: InputDecoration(
                prefixIcon: Icon(Icons.lock_open,color:Colors.white),
                hintText: "Please re-enter password here",
                focusColor: Colors.white,
              ),
            ),
            IconButton(
              icon: Icon(Icons.send),
              color: Colors.white,
              splashColor:Colors.white,
              onPressed: ()async{
                validation=checkvalidation(controller1.text,controller2.text,controller3.text,fasketask);
                if(_formkey.currentState.validate()){
                  changepage();
                }
              },
            )
          ]
        )
        )
        ),
      )
    );
  }
}
class Signinpage extends StatefulWidget {
  @override
  _SigninpageState createState() => _SigninpageState();
}

class _SigninpageState extends State<Signinpage> {
  final controller1 =TextEditingController();
  final controller2 =TextEditingController();  
  final _formkey=GlobalKey<FormState>(); 
  void dispose(){
    super.dispose();
    controller1.dispose();
    controller2.dispose();
    _write();
  }
  bool validation=false;
  bool obscuretext=true;
  bool changeobscuretext()
  {
    this.setState(() {
      obscuretext = !obscuretext;
    });
    return obscuretext;
  }
  void changepage(){
    this.setState(() {
      FocusScope.of(context).unfocus();
      Navigator.of(context).pop();
      Navigator.push(context,MaterialPageRoute(builder: (context) => MyHomePage()));
    });
  }
  void registerpage(){
    this.setState(() {
      FocusScope.of(context).unfocus();
      Navigator.of(context).pop();
      Navigator.push(context,MaterialPageRoute(builder: (context) => Registerpage()));
    });
  }
  @override
  void initState(){
    this.setState(() {
      if(username !=null && password != null){
      }
      signin();
      getuserdata();
    });
  }
  void signin()async{
      dynamic res = await _auth.signin();
      if(res==null){
        print("failed to connect to server");
      }
      else{
        print(res.uid);
        }
  }
  void getuserdata()async{
    userlist = await getallusers();
    var check=checkcredentials(username,password);
    if (check==true){
      changepage();
    }
  }
 _write()async{
   final prefs = await SharedPreferences.getInstance();
   final String keyuser="username";
   final String keypasswords="passwords";
   prefs.setString(keyuser,currentuser.username);
   prefs.setString(keypasswords,currentuser.password);
 }
  bool checkcredentials(String a,String b){
    for(var i =0;i<userlist.length;i++){
      if(a==userlist[i].username){
        if(b ==userlist[i].password){
          currentuser=Users(userlist[i].username,userlist[i].password,userlist[i].taskname);
          currentuser.getid(userlist[i].id);
          return true;
        }
      }
    }
    return false;
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.grey.shade700,
      body:Container(
        padding: EdgeInsets.only(top:100,right:20,left:20),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.all(Radius.circular(20)),
          gradient: new LinearGradient(
                      colors: [Colors.teal.shade300,Colors.indigo.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
        ),
        child: Form(
          key:_formkey,
          child:Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children:<Widget>[
            Text("Signin",style:smallWhiteTitle),
            TextFormField(
              validator: (val)=>!validation?"Enter proper":null,
              controller: controller1,
              decoration: InputDecoration(
                prefixIcon: Icon(Icons.person,color:Colors.white),
                hintText: "Please enter username here",
                focusColor: Colors.white,
              )
            ),
            TextFormField(
              validator: (val)=>!validation?"Enter proper":null,
              controller:controller2,
              decoration: InputDecoration(
                prefixIcon: Icon(Icons.lock_open_outlined,color:Colors.white),
                hintText: "Enter your password here",
                focusColor: Colors.white,
                suffixIcon: (obscuretext)?IconButton(icon:Icon(Icons.remove_red_eye_outlined),onPressed:()=>changeobscuretext(),color:Colors.white):IconButton(icon:Icon(Icons.remove_red_eye_rounded),onPressed: ()=>changeobscuretext(),color:Colors.white),
              ),
              obscureText: obscuretext,
            ),
            IconButton(
              icon: Icon(Icons.send),
              color: Colors.white,
              splashColor:Colors.white,
              onPressed: ()async{
                validation=checkcredentials(controller1.text,controller2.text);
                if(_formkey.currentState.validate()){
                  changepage();
                }
              },
            ),
            FlatButton(
              onPressed:()=>registerpage(),
              color: Colors.amber,
              child:Text("Register"),
              shape:RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
            ),
          ]
        )
        )
      )
    );
  }
}
Widget viewcalendar(CalendarController _calendarcontroller,BuildContext context) {
  return AlertDialog(
      content:Container(
        width:330,
        height: 320,
        child:TableCalendar(  
            initialCalendarFormat: CalendarFormat.month,  
            onDaySelected: (a,b,c,)=>{calendarselected=false},
            calendarController: _calendarcontroller,  
          ),
      ),
    );
}  

class MyHomePage extends StatefulWidget {
  @override
  _MyHomePageState createState() => _MyHomePageState();
}

bool calendarselected=false;
class _MyHomePageState extends State<MyHomePage> {
  CalendarController _calendarcontroller= CalendarController();
  final _formkey=GlobalKey<FormState>();  
  @override
  void initstate()
  {
    super.initState();
    _calendarcontroller = CalendarController();
  }
  @override
  void dispose()
  {
    _calendarcontroller.dispose();
    super.dispose();
  }
  void getdate(DateTime selecteddate){
    Future.delayed(const Duration(seconds: 2));
    Navigator.of(context).pop();
  }
  void timerpage(String time){
    var duration = int.parse(time);
    Navigator.of(context).pop();
    Navigator.push(context,MaterialPageRoute(builder: (context) => Timer(duration)));
  }
  _remove()async{
  final prefs = await SharedPreferences.getInstance();
   final String keyuser="username";
   final String keypasswords="passwords";
   prefs.remove(keyuser);
   prefs.remove(keypasswords);
   username=" ";
   password=" ";
   Navigator.of(context).pop();
   Navigator.push(context,MaterialPageRoute(builder: (context) => Signinpage())); 

  }
  List<Widget> changeprogressbar()
  {
    var temp;
    this.setState(() {
      temp=display_dailytask();
    });
    return temp;
  }
  List<Widget> changedailytask(BuildContext context){
    var temp;
    this.setState(() {
      temp=display_dailytasktest(context);
    });
    return temp;
  }
  final controller =TextEditingController();
  final controller1=TextEditingController( );
  String duration;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      body:Stack(
        children:<Widget>[
          Container(
        color: Colors.limeAccent,
        child: Column(
          children: <Widget>[
            Stack(
              children: <Widget>[
                Container(
                  padding: EdgeInsets.all(10),
                  constraints: BoxConstraints.expand(height:400),
                  decoration: BoxDecoration(
                    gradient: new LinearGradient(
                      colors: [Colors.blueGrey.shade400,Colors.blueGrey.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
                    borderRadius: BorderRadius.only(bottomRight: Radius.circular(300)),
                  ),
                  child:Align(alignment: Alignment.topLeft,child: Row(
                    children: <Widget>[
                      Expanded(child:Container(
                      padding: EdgeInsets.only(top: 30),
                      child:Text(
                        "Your daily tasks",
                        style: smallWhiteTitle,
                      ),
                    )),
                    IconButton(
                      icon:Icon(Icons.logout),
                      padding:EdgeInsets.only(top:30),
                      onPressed:()=>_remove(),
                    ),
                    IconButton(
                      icon:Icon(Icons.alarm),
                      padding:EdgeInsets.only(top:30),
                      onPressed:(){showDialog(context: context,
                        builder: (BuildContext context){
                          return AlertDialog(
                            content: SingleChildScrollView(
                              scrollDirection: Axis.vertical,
                              child:TextFormField(
                              keyboardType: TextInputType.number,
                              inputFormatters: [WhitelistingTextInputFormatter.digitsOnly],
                              onChanged: (value){
                                setState(() {
                                  duration=value;
                                });
                              },
                              controller: controller1,
                              decoration:InputDecoration(
                                hintText: "Enter time in seconds",
                                suffixIcon: IconButton(
                                  icon:Icon(Icons.send),
                                  onPressed:()=>timerpage(duration),
                                ),
                              )
                            )
                            )
                          );
                        }
                        );
                      }
                    ),
                    IconButton(icon: Icon(Icons.calendar_today),
                    padding: EdgeInsets.only(top:30),
                     onPressed:(){
                       showDialog(context: context,
                        builder: (BuildContext context){
                          return AlertDialog(
                            content: Container(
                              width:300,
                              height:360,
                              child: TableCalendar(  
                                    initialCalendarFormat: CalendarFormat.month,  
                                    onDaySelected: (a,b,c,)=>getdate(a),
                                    calendarController: _calendarcontroller,  
                                  ),),
                          );
                        }
                        );
                     }),
                    ],
                )),
                ),
                Container(
                  height:220,
                  padding:EdgeInsets.only(top:90),
                  child:ListView(
                    scrollDirection: Axis.horizontal,
                    children: changeprogressbar(),
                  )
                ),
              Container(
                padding:EdgeInsets.only(top:220),
                child:Row(
                  children: <Widget>[
                    Text("Yourtasks",style:smallWhiteTitle),
                    IconButton(
                      icon:Icon(Icons.add),
                      onPressed: (){showDialog(context: context,
                        builder: (BuildContext context){
                          return AlertDialog(
                            content: SingleChildScrollView(
                              scrollDirection: Axis.vertical,
                              child:Text("The app is still in development state. You will be able to add more task in the upcoming updates. Sorry about this :-(",
                              style:smallBlacktask)
                            )
                          );
                        }
                        );
                      },
                      splashColor: Colors.blue,
                    )
                  ])),
                  Padding(padding: EdgeInsets.only(top:20)),
            Container(
              height:MediaQuery.of(context).size.height,
              padding:EdgeInsets.only(top:270),
              child:ListView(
                scrollDirection: Axis.vertical,
                children: changedailytask(context),
              )
            ),
            ]
            ),
          ]
        ) 
      ),
     ]
     )
    );
  }
}

List <Widget> display_dailytask() {
  final DateTime now = DateTime.now();
  final DateFormat formatter= DateFormat("dd-MM");
  String formattedDate = formatter.format(now);
  List <Widget> list=[];
  List <Widget> row=[];
  for (var i=0;i<currentuser.taskname.length;i++){
    row.add(displaycontainer(formattedDate));
  }
  list.add(new Row(mainAxisAlignment: MainAxisAlignment.start,children:row));
  return row;
}
TextStyle smallWhiteTitle = new TextStyle(
  fontFamily: "Helvetica",
  fontWeight: FontWeight.bold,
  fontSize: 20,
  color: Colors.white
);

TextStyle smallBlacktask = new TextStyle(
  fontFamily: "Avenir",
  fontWeight: FontWeight.normal,
  fontSize: 18,
  color: Colors.black,
);
TextStyle bigwhitetask = new TextStyle(
  fontFamily: "Avenir",
  fontWeight: FontWeight.normal,
  fontSize: 23,
  color: Colors.white
);
Widget displaycontainer(String date){
  return new InkWell(
    onTap: ()=>{},
    child:Container(
    margin: EdgeInsets.only(right: 5,left:5,bottom:5),
    height:200,
    width: 300,
    padding: EdgeInsets.all(15),
    decoration: BoxDecoration(
      color: Colors.cyan,
      borderRadius: BorderRadius.all(Radius.circular(15)),
      boxShadow: [
        new BoxShadow(
          color: Colors.grey.shade900,
          blurRadius: 5.0,
        )
      ]
    ),
    child:Row(
      children:<Widget>[
        Expanded(child:
        Column(
      children: <Widget>[
        Expanded(
          child: Column(
            children: <Widget>[
              Text(date,style:smallBlacktask),
              Column(
                children: <Widget>[
                Align(alignment: Alignment.topLeft,
                child:Row(
                  children:<Widget>[Text(
                  "Today's Tasks: ",
                  style:smallBlacktask,
                ),Text(currentuser.taskname.length.toString(),style: smallBlacktask,)
                  ])
                ),
                Align(alignment:Alignment.topLeft,
                child:Text(
                  "Completed Tasks: 0",
                  style:smallBlacktask,
                )
                ),
                Align(alignment:Alignment.topLeft,
                child:Row(
                  children:<Widget>[
                    Text(
                  "Pending Tasks: 0",
                  style:smallBlacktask,
                ),
                Text(currentuser.taskname.length.toString(),style: smallBlacktask,)
                  ])
                )
                ]
              )
            ]
          )
        )
      ]
    ),),
    progressbar(slidervalue),
    ]
    ),
  )
  );
}
Widget progressbar(double completed){
  var percentcomp = (completed).toStringAsFixed(2);
  return Column(children: <Widget>[
      Align(
      alignment: Alignment.bottomRight,
      child:  SizedBox(
      width:20,
      height:20,
      child: CircularProgressIndicator(
        strokeWidth: 20,
        backgroundColor: Colors.yellow.shade900,
        valueColor: new AlwaysStoppedAnimation<Color>(Colors.red),
        value: completed,
        )
      )
    ),
    Padding(padding: EdgeInsets.only(top:15)),
    Text("%$percentcomp"),
    Text("completed"),
  ]);
}
List <Widget> display_dailytasktest(BuildContext context){
  List <Widget> list=[];
  List <Widget> row=[];
  for (int i=0;i<currentuser.taskname.length;i++){
    row.add(Taskcontainer(currentuser.taskname[0]));
  }
  for(int i=0;i<quotes.length;i++){
  row.add(quotescont(i));
  }
  list.add(new Row(mainAxisAlignment: MainAxisAlignment.start,children:row));
  return row;
}
Widget quotescont(int i){
  return new Container(
    padding: EdgeInsets.all(10),
    margin: EdgeInsets.all(5),
    height:110,
    width: 300,
    decoration: BoxDecoration(
      gradient: new LinearGradient(
                      colors: [Colors.indigo.shade300,Colors.indigo.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
      borderRadius: BorderRadius.all(Radius.circular(20)),
      boxShadow: [
        new BoxShadow(
          color: Colors.grey,
          blurRadius: 5.0,
        )
      ]
    ),
    child: Column(
      children: <Widget>[
        Align(
          alignment:Alignment.centerLeft,
          child:Text(quotes[i][0],
          style:bigwhitetask,
        )),
        Align(
          alignment:Alignment.bottomRight,
          child: Text(quotes[i][1],
          style:bigwhitetask,)
        )
      ]
    )
  );
}

class Taskcontainer extends StatefulWidget {
  String name;
  Taskcontainer(this.name);
  @override
  _TaskcontainerState createState() => _TaskcontainerState();
}

class _TaskcontainerState extends State<Taskcontainer> {
  var username=currentuser.username;
  final controller=TextEditingController();
  String del="no current task";
  void save(String a,BuildContext context){
    Navigator.of(context).pop();
    FocusScope.of(context).unfocus();
    currentuser.taskname[0]=a;
    update(currentuser);
  }
  @override
  Widget build(BuildContext context) {
    return new Container(
    padding: EdgeInsets.all(10),
    margin: EdgeInsets.all(5),
    height:180,
    width: 300,
    decoration: BoxDecoration(
      gradient: new LinearGradient(
                      colors: [Colors.indigo.shade300,Colors.indigo.shade700],
                      begin: const FractionalOffset(1.0, 1.0),
                      end: const FractionalOffset(0.3, 0.3),
                      stops:[0.0,1.0],
                      tileMode: TileMode.clamp,
                    ),
      borderRadius: BorderRadius.all(Radius.circular(20)),
      boxShadow: [
        new BoxShadow(
          color: Colors.grey,
          blurRadius: 5.0,
        )
      ]
    ),
    child: Row(
      children:<Widget>[Expanded(child:Column(
      children: <Widget>[
        (widget.name !="no current task")?Align(
          alignment:Alignment.topLeft,
          child:Text(
            "Today's Tasks:",
            style:bigwhitetask,
          )
        ):Container(),
        Align(
          alignment:Alignment.center,
          child:Text(widget.name,
          style:bigwhitetask,
        )),
    IconButton(
      icon:Icon(Icons.edit),
      onPressed:(){showDialog(context: context,
                        builder: (BuildContext context){
                          return AlertDialog(
                            content: SingleChildScrollView(
                              scrollDirection: Axis.vertical,
                              child:TextField(
                                controller:controller,
                                decoration: InputDecoration(
                                  hintText: "Enter new task name",
                                  suffixIcon: IconButton(icon:Icon(Icons.send),
                                  onPressed: ()=>save(controller.text,context),                                 
                                ),
                              )
                            )
                        ));
                        }
                        );
                      },
      ),
      (widget.name !="")?Slider(  
      min: 0,  
      max: 100,  
      value: slidervalue,  
      onChanged: (value) {  
        setState(() {  
          slidervalue = value;  
        });  
      },  
    ):Container(),  
    ])
  )])
  );
}
}