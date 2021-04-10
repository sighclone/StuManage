import 'package:firebase_auth/firebase_auth.dart';
class Authservice{
  final FirebaseAuth _auth =FirebaseAuth.instance;
   Future signin() async{
    try{
      AuthResult result = await _auth.signInAnonymously();
      FirebaseUser user = result.user;
      return user;
    }
    catch(e){
      print(e);
      return null;
    }
  }
}