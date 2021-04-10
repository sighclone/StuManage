import 'package:flutter/animation.dart';
import 'package:flutter/material.dart';
import 'main.dart';
import 'dart:math';
class Timer extends StatefulWidget {
  int duration;
  Timer(this.duration);
  @override
  _TimerState createState() => _TimerState();
}

class _TimerState extends State<Timer>
with TickerProviderStateMixin {
  AnimationController controller;
  int count=0;
  String get timerString {
    Duration duration = controller.duration * controller.value;
    return '${duration.inMinutes}:${(duration.inSeconds % 60).toString().padLeft(2, '0')}';
  }
  @override
  void initState(){
    super.initState();
    controller=AnimationController(
      value:1.00,
      vsync: this,
      duration: Duration(seconds: widget.duration),
    )..addStatusListener((AnimationStatus status) {if(status == AnimationStatus.completed && count>0){back();} });
  }
  void back(){
    this.setState(() {
      Navigator.of(context).pop();
    Navigator.push(context,MaterialPageRoute(builder: (context) => MyHomePage()));
    });

  }
  void dispose()
  {
    super.dispose();
    controller.dispose();
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white10,
      body:AnimatedBuilder(
        animation:controller,
        builder:(context,child){
          return Padding(
            padding:EdgeInsets.all(8.0),
            child:Column(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children:<Widget>[
                Expanded(
                  child:Align(
                    alignment: FractionalOffset.center,
                    child:AspectRatio(
                      aspectRatio: 1.0,
                      child:Stack(
                        children:<Widget>[
                          Positioned.fill(
                            child:AnimatedBuilder(
                              animation:controller,
                              builder:(BuildContext context,Widget child){
                                return CustomPaint(
                                  painter:Customprogressbar(
                                    animation:controller,
                                    background:Colors.white,
                                    color:Colors.blue,
                                  )
                                );
                              }
                            )
                          ),
                          Align(
                            alignment: FractionalOffset.center,
                            child:Column(
                              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: <Widget>[
                                Text("Count Down Timer",style:smallWhiteTitle),
                                AnimatedBuilder(
                                  animation:controller,
                                  builder:(BuildContext context,Widget child){
                                    return Text(timerString,style:smallWhiteTitle);
                                  }
                                )                               
                              ],
                            )
                          )
                        ]
                      )
                    )
                  )
                ),
                AnimatedBuilder(
                  animation: controller,
                      builder: (context, child) {
                        return FloatingActionButton.extended(
                            onPressed: () {
                              if (controller.isAnimating)
                                controller.stop();
                              else {
                                if(count ==0 && controller.value ==0.0){
                                  count=1;
                                }
                                if (count==0){
                                controller.reverse(
                                    from: controller.value == 0.0
                                        ? 1.0
                                        : controller.value);}
                                if(count==1){
                                  back();
                                }
                              }
                            },
                            icon: Icon(controller.isAnimating
                                ? Icons.pause
                                : Icons.play_arrow),
                            label: Text(
                                controller.isAnimating ? "Pause" : (controller.value==0.0)?"Exit":"Play"));
                      }),        
              ]
            )
          );
        }
      )
    );
  }
}
class Customprogressbar extends CustomPainter {
  Customprogressbar({
    this.animation,
    this.background,
    this.color,
  }
  ):super(repaint:animation);
  final Animation<double> animation;
  final Color background,color;
  @override
  void paint(Canvas canvas,Size size){
    Paint paint =Paint()
    ..color=background
    ..strokeWidth =10.0
    ..strokeCap = StrokeCap.butt
    ..style =PaintingStyle.stroke;
    canvas.drawCircle(size.center(Offset.zero),size.width/2.0, paint);
    paint.color=color;
    double progress =(1.0-animation.value)*2* pi;
    canvas.drawArc(Offset.zero & size,pi*1.5,-progress, false, paint);
  }
  @override
  bool shouldRepaint(Customprogressbar old) {
    return animation.value != old.animation.value ||
        color != old.color ||
        background != old.background;
  }
}