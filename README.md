# Bird-and-Pipe-Game
تجربه صنع الالعاب بيونيتي , شكل اللعبة النهائي :



https://user-images.githubusercontent.com/107775566/234366767-0c10fd07-92fd-4fc1-b48c-efbc9b31f2d8.mp4



## 1- شكل الواجهه
![الأجزاء](https://user-images.githubusercontent.com/107775566/234362391-9912629c-4008-4e8d-b53f-1052ba5b69f0.png)
### project
فيها كل الاشياء الموجودة باللعبة زي الاصوات وملفات الاكواد والصور والخطوط والاشكال وغيرها
### scene
المشهد وهو اللي بيمثل باغلب الالعاب المستوى وبيكون الشيء الظاهر بالشاشه
### hierachy
يحتوي على جميع العناصر الموجودة في المشهد الحالي
ويحتوي على كائن اللعبة واللي بيكون زي الحاويه او الشي اللي بيشيل لنا المكونات مع بعض عشان نقدر نتحكم فيها بسهوله داخل المشهد وكل شي داخل المشهد بيكون كائن لعبة (objectgame)
### inspector
 للتحكم بخصائص المكونات والكائنات الموجودة بالمشهد مثل موضعه وحجمه وتدويره , ويسمح لنا نضيف خصائص اخرى او نضيف كود للكائن هذا
 
 ## 2- scripts
 الاكواد بتكون بلغة c# وبتكون سهله تشبه جافا
 #### بكون عندنا دالتين :
 ##### a_ start()
 بتتشغل اول ما يتشغل المشهد
 ##### b_ update()
 بتقعد تتشهل طول ما احنا بهذا المشهد تجلس تنعاد
 
 ### 2.1- شرح بعض الاكود في BridScript 
 ##### بنتحكم فيه بالعصفور وتحركاته
 #### أ_ اذا ضغط المستخدم مسافة خل العصفور بنقز
 
    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
 flapStrength المسافة اللي بينقزها العصفور 
 Vector2 عشان على محور الواي نبغا
 .up عشان يطلع فوق
 myRigidbody اوبجكت بيمثل العصفور
 if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) اذا ضغط المستخدن مسافة وكان العصفور داخل الشاشه 
 
 #### ب_ اذا طلع العصفور برا الشاشه خل اللعبة تنتهي 
 
     if(transform.position.y>16 || transform.position.y<-16){
        logic.gameOver();
        birdIsAlive = false;
        }
 16, -16 خارج حدود الشاشه 
 transform.position.y موقع العصفور على محور واي
 logic.gameOver() بيستدعي داله game over الموجودة في LogicScript
 logic اوبجكت من كلاس LogicScript
 
 #### ج_ عشان ااشر على العصفور اللي بالواجهه الرسويمة واقدر اعرف خصائصه واعدل
 
     logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
  وفي التاقات خليت تاق العصفور لوجيك
  
  #### د_ عشان اقول لو صار تصادم خل اللعبة تنتهي
  
      private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
      }
      
 ### 2.2- شرح بعض الاكود في LogicScript
 ##### ما بيكون فيه الدالتين الاساسيه حقت التسغيل والتحديث لانه مابيكون تابع لمشهد معين بس بنحط فيه الدوال اللي بنستخدمها مع الكائنات عند حدوث حدث معين
 #### أ_ عشان ازيد على الدرجة واحد اذا تعدى انبوب
     
     public void addScore(int scoreToAdd){
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
     }
 
 #### ب_ لاعادة تحميل اللعبة عند الخسارة
    public void restartGame(){
        SceneManager.LoadScene("SampleScene");
     }
 SceneManager.LoadScene لانتقال لمشهد جديد
 عشان نستخدم SceneManager لازم نستدعي فوق using UnityEngine.SceneManagement;
 
 #### ج_ لانهاء اللعبة اذا خسر
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
 SetActive(true); بتخلي المشهد اللي قبل النقطة نشط ويظهر فوق المشهد الحالي
 
<!-- ### 2.3- شرح بعض الاكود في PipMoveScript 
 
 ### 2.4- شرح بعض الاكود في PipeSpawnScript 
 
 ### 2.5- شرح بعض الاكود في PipeMiddleScript
 
 ### 2.6- شرح بعض الاكود في CloudScript
  
 ### 2.7- شرح بعض الاكود في MoveCloud-->
