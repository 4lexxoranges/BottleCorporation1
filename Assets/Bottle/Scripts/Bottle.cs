
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public enum BottleID { defaultBottle, champange, cocaCola };

public class Bottle : MonoBehaviour
{
    public float fuelSize;
    public float fuelUsage;
    public GameObject fuelProgressBar;
    

    [SerializeField] float fuelAdd = 8;
    [SerializeField] float flySpeed = 50f;
    [SerializeField] float rotSpeed = 100f;
    [SerializeField] AudioClip flySound;
    [SerializeField] AudioClip boomSound;
    [SerializeField] AudioClip loseSound;
    [SerializeField] AudioClip winSound;
    
    [SerializeField] public Text coins;
    [SerializeField] Text brilliants;

    [SerializeField] ParticleSystem flyParticle;
    [SerializeField] ParticleSystem boomParticle;
    [SerializeField] ParticleSystem winParticle;
    public int coinsCount;
    public int brilliantsCount;


    public DeathMenu deathMenu;
    private bool isPaused = false;
    public GameObject pp;
    
   
    

    private float currentFuel;
    Rigidbody rigidBody;
    AudioSource audioSource;
    


    enum State { Playing, Dead, NextLevel, };
    State state = State.Playing;

    // Start is called before the first frame update
    public void Start()
    {
        
        
        currentFuel = fuelSize;
        state = State.Playing;
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
        
        if(PlayerPrefs.HasKey("coinsFinal"))
        {
            coinsCount = PlayerPrefs.GetInt("coinsFinal");
        }
        else
        {
            coinsCount = 0;
        }
        coins.text = "Coins: " + coinsCount.ToString();
        if (PlayerPrefs.HasKey("brilliantsFinal"))
        {
            brilliantsCount = PlayerPrefs.GetInt("brilliantsFinal");
        }
        else
        {
            brilliantsCount = 0;
        }

        brilliants.text = "Brilliants: " + brilliantsCount.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    

    void DontFuel()//Закончилось топливо
    {

        state = State.Dead;
        audioSource.Stop();
        audioSource.PlayOneShot(loseSound);
        deathMenu.ToggleEndMenu();
        

    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (state == State.Playing)
        {

            //Launch();
            //Rotation();
            
            if (currentFuel <= 0)
            {
                DontFuel();
                
                
            }
            if(Input.GetKey(KeyCode.Escape) && isPaused)
            {
                pp.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
            }
            else if(Input.GetKey(KeyCode.Escape) && isPaused)
            {
                pp.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;
            }
        }  
    }
    
    public void pauseOn()
    {
        pp.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        
    }
    public void _continue()
    {
        pp.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
    public void exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Launch(bool ispressed)//Взлет
    {

        //if (Input.GetKey(KeyCode.Space))
        if (ispressed)
        {
            rigidBody.AddRelativeForce(-Vector3.up);
            if (audioSource.isPlaying == false)
                audioSource.PlayOneShot(flySound);
            flyParticle.Play();
            fuelProgress();


        }
        else
        {
            audioSource.Pause();
            flyParticle.Stop();
        }

    }
    


    void fuelProgress()//Топливо
    {

        currentFuel -= fuelUsage * Time.deltaTime;
        fuelProgressBar.transform.localScale = new Vector2(currentFuel / fuelSize, 1);
    }
    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Fuel")
        {

            currentFuel += fuelAdd;
            Destroy(trigger.gameObject);
        }
        if (trigger.gameObject.tag == "Coin")
        {
            coinsCount += 100;
            coins.text = "Coins:" + coinsCount.ToString();

            SavePlayer();
            Destroy(trigger.gameObject);
        }
        if (trigger.gameObject.tag == "Brilliant")
        {
            brilliantsCount += 1;
            brilliants.text = "Brilliants:" + brilliantsCount.ToString();

            SavePlayer2();
            Destroy(trigger.gameObject);
        }
    }
    void SavePlayer()
    {
        PlayerPrefs.SetInt("coinsFinal", coinsCount);
    }
    void SavePlayer2()
    {
        PlayerPrefs.SetInt("brilliantsFinal", brilliantsCount);
    }
    public void Rotation(bool ispressed)//Поворот ракеты
    {
        float rotationSpeed = rotSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime); 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

    }
    public void RotationLeft()
    {
        float rotationSpeed = rotSpeed * Time.deltaTime;
        transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    public void RotationRight()
    {
        float rotationSpeed = rotSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (state == State.Dead || state == State.NextLevel)
        {
            return;
        }
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                Lose();
                break;
            case "Friendly":
                print("OK");
                break;
            case "Money":
                
                break;
            case "Battery":
                print("You get energy");
                break;
            case "Finis":
                Finish();
                break;
        }
        

    }
    public void Lose()//Проигрыш
    {
        state = State.Dead;
        audioSource.Stop();
        audioSource.PlayOneShot(boomSound);
        boomParticle.Play();
        deathMenu.ToggleEndMenu();
        Invoke("TimeScale", 1f);
        
    }
    void TimeScale()
    {
        Time.timeScale = 0;
    }
    public void Finish()//Финиш
    {
        state = State.NextLevel;
        audioSource.Stop();
        audioSource.PlayOneShot(winSound);
        winParticle.Play();
        Invoke("LoadNextLevel", 4f);
    }
    /*public void LoadNextLevel() // Finish
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevelIndex = currentLevelIndex + 1;

        if (nextLevelIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextLevelIndex = 0; // цикл 
        }

        SceneManager.LoadScene(nextLevelIndex);

    }*/
    public void LoadFirstLevel() // Lose
    {
        SceneManager.LoadScene(1);
    }
    public void Test1(bool x)
    {
        Debug.Log( x ? "pressed" : "not pressed");
    }    
}

