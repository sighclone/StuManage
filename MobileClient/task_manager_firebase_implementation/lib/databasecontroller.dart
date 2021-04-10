import 'package:firebase_database/firebase_database.dart';

import 'classes.dart';
final databaseReference = FirebaseDatabase.instance.reference();

DatabaseReference savenewuser(Users a){
  String rootname =a.username;
  var id = databaseReference.child('Users/$rootname');
  id.set(a.toJson());
}
Future update(Users a){
  String rootname=a.username;
  var id = databaseReference.child('Users/$rootname');
  id.update(a.toJson());
}
Future getallusers() async{
  DataSnapshot userrecord= await databaseReference.child('Users/').once();
  List<Users> userlist=[];
  if (userrecord.value != null){
    userrecord.value.forEach((key,value){
      Users tempuser = addvalues(value);
      tempuser.getid(databaseReference.child('Users/'+key));
      userlist.add(tempuser);
      print(tempuser.taskname.length);
    }
    );
  }
  return userlist;
}