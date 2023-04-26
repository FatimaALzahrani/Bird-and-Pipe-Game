# Bird-and-Pipe-Game

<!-- <p align="right"> -->
## المحتويات
* [1. ماهي unity؟](#ماهيunity؟)
* [2.الشكل_النهائي](#الشكل_النهائي)
* [3. شكل واجهة البرنامج](#شكل_الواجهه)
  * [1. جزء  (project)](#project)
  * [2. جزء المشهد (scene)](#scene)
  * [3. جزء التسلسل الهرمي (hierachy)](#hierachy)
  * [4. جزء التحكم بالخصائص (inspector)](#inspector)
* [4.الاكواد (scripts)](#scripts)
  * [مقدمة](#مقدمة)
  * [شرح بعض الكلاسات/السكربتات الموجودة باللعبة](#شرح_بعض_الكلاسات)
    * [1. كلاس BridScript](#BridScript)       
    * [2. كلاس LogicScript](#LogicScript)
    * [3. كلاس PipMoveScript](#PipMoveScript)
    * [4. كلاس PipeSpawnScript](#PipeSpawnScript)
    * [5. كلاس PipeMiddleScript](#PipeMiddleScript)
    * [6. كلاس CloudScript](#CloudScript)
    * [7. كلاس MoveCloud](#MoveCloud)
  
## ماهيunity؟

Unity هي منصة تطوير الألعاب الحاسوبية والتطبيقات التفاعلية ثلاثية الأبعاد والثنائية الأبعاد

تتميز Unity بأنها توفر بيئة تطوير متكاملة وسهلة الاستخدام تتضمن أدوات لتصميم الرسوميات وإدارة الأصول والبرمجة والاختبار والنشر. كما تدعم Unity العديد من لغات البرمجة مثل C# وJavaScript و Boo، مما يسمح للمطورين بالاختيار من بين عدة خيارات لبرمجة تطبيقاتهم.

يمكن استخدام Unity لتطوير ألعاب مختلفة ومنها الألعاب ثنائية الأبعاد والثلاثية الأبعاد وألعاب الأجهزة المحمولة وألعاب الكمبيوتر وألعاب الواقع الافتراضي والواقع المعزز والتطبيقات التفاعلية وغيرها.

ومن خلال تجربه فهي سهله وممتعه
<hr/>

 ## الشكل_النهائي

https://user-images.githubusercontent.com/107775566/234366767-0c10fd07-92fd-4fc1-b48c-efbc9b31f2d8.mp4  
<hr>
## شكل_الواجهه
![الأجزاء](https://user-images.githubusercontent.com/107775566/234362391-9912629c-4008-4e8d-b53f-1052ba5b69f0.png)
### project
فيها كل الاشياء الموجودة باللعبة زي الاصوات وملفات الاكواد والصور والخطوط والاشكال وغيرها
### scene
المشهد وهو اللي بيمثل باغلب الالعاب المستوى وبيكون الشيء الظاهر بالشاشه
### hierachy
يحتوي على جميع العناصر الموجودة في المشهد الحالي
ويحتوي على كائن اللعبة واللي بيكون زي الحاويه او الشي اللي بيشيل لنا المكونات مع بعض عشان نقدر نتحكم فيها بسهوله داخل المشهد وكل شي داخل المشهد بيكون كائن لعبة (GameObject)
### inspector
  يتيح الوصول إلى المعلومات المفصلة حول مكونات اللعبة والأشياء الأخرى في مشروع
 ويستخدم للتحكم بخصائص المكونات والكائنات الموجودة بالمشهد مثل موضعه وحجمه وتدويره , ويسمح لنا نضيف خصائص اخرى او نضيف كود للكائن هذا
 <hr/>
 
 ## scripts
 ### مقدمة
 الاكواد بتكون بلغة c# وبتكون سهله تشبه جافا
 #### بيكون عندنا دالتين :
 ##### a_ start()
 بتتشغل اول ما يتشغل المشهد
 ##### b_ update()
 بتقعد تتشهل طول ما احنا بهذا المشهد تجلس تنعاد
 
 ### شرح_بعض_الكلاسات
 ### BridScript 
 ##### بنتحكم فيه بالعصفور وتحركاته
 #### أ_ اذا ضغط المستخدم مسافة خل العصفور بنقز
 
    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
 flapStrength المسافة اللي بينقزها العصفور 
 <br>Vector2 عشان على محور الواي نبغا
 <br>.up عشان يطلع فوق
 <br>myRigidbody اوبجكت بيمثل العصفور
 <br>if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) اذا ضغط المستخدن مسافة وكان العصفور داخل الشاشه 
 
 #### ب_ اذا طلع العصفور برا الشاشه خل اللعبة تنتهي 
 
     if(transform.position.y>16 || transform.position.y<-16){
        logic.gameOver();
        birdIsAlive = false;
        }
 16, -16 خارج حدود الشاشه 
 <br>transform.position.y موقع العصفور على محور واي
 <br>logic.gameOver() بيستدعي داله game over الموجودة في LogicScript
 <br>logic اوبجكت من كلاس LogicScript
 
 #### ج_ عشان ااشر على العصفور اللي بالواجهه الرسويمة واقدر اعرف خصائصه واعدل
 
     logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
  وفي التاقات خليت تاق العصفور لوجيك
  
  #### د_ عشان اقول لو صار تصادم خل اللعبة تنتهي
  
      private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
      }
      
### LogicScript
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
 <br>عشان نستخدم SceneManager لازم نستدعي فوق using UnityEngine.SceneManagement;
 
 #### ج_ لانهاء اللعبة اذا خسر
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
 SetActive(true); بتخلي المشهد اللي قبل النقطة نشط ويظهر فوق المشهد الحالي
 
 ### 4.2.3. شرح بعض الاكود في PipMoveScript 
 فايدة هالكلاس تحريك الانابيب
 #### أ_ عشان نحرك الانبوب ليسار 
 
    transform.position= transform.position+(Vector3.left*moveSpeed) *Time.deltaTime;
بتطلع ان العصفور جالس يمشي وفي الحقيقة هو مكانه بس الانابيب هي اللي تمشي
#### ب_ اذا وصل الانبوب برا الشاشه نحذفه

    if (transform.position.x < deadZone){
            Debug.Log("Pip deleted");
            Destroy(gameObject);
        }
 فايدة هذي الخطوه ان اللعبة بتجلس تنشئ انابيب الين يخسر اللاعب فلو ما حذفت الانبوب اللي خلاص طلع ومعد نحتاجه بيصير عندي كثير انابيب وبتعلق
 ### PipeSpawnScript  
 انشاء انابيب باشكال مختلفه 
  أ_ داله تنشء انابيب نختلفة من الانبوب الاساسي pip بشكل عشوائي داخل نطاق محدد للطول
    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
     }
### PipeMiddleScript 
 فائدته زيادة الدرجة عند تخطي الانبوب
 أ_ عند تصادم الطائر والمشار اليه بالطبقة الثالثه سابقا بالمسافة بين الانبوبين يزيد درجة 
 
       private void OnTriggerEnter2D(Collider2D collision){
         if (collision.gameObject.layer == 3){
            logic.addScore(1);
          }
        }
 ### CloudScript 
  PipeSpawnScript انشاء السحب باشكل مختلفة ودوالها مشابهه ل 
  
 ### MoveCloud 
 PipMoveScript تحريك السحب طوال اللعبة ودوالها مشابهه ل

