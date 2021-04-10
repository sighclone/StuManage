import 'package:firebase_database/firebase_database.dart';

class Users{
  String username;
  String password;
  DatabaseReference id;
  List<String> taskname;
  Users(this.username,this.password,this.taskname);
  void getid(id){
    this.id=id;
  }
  Map<String,dynamic> toJson(){
    return{
      'username':this.username,
      'password': this.password,
      'TaskList': {'latestTask': this.taskname[0]},
    };
  }
}
Users addvalues(record){
  Map<String,dynamic> attributes={
    "username":'',
    'password':'',
    "id":'',
    "taskname":'',
  };
  record.forEach((key,value){
    if(key=="TaskList"){
      attributes['taskname']=value['latestTask'];
    }
    else{
    attributes[key]=value;
    }
  }
  );
  List<String> temp=[];
  temp.add(attributes['taskname']);
  Users tempuser= Users(attributes['username'],attributes['password'],temp);
  return tempuser;
}