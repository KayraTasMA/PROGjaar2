using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject prefab;
        private float worldTime = 0f;
        private List<GameObject> balls = new List<GameObject>();
        private float ballspawn = 100;
        private GameObject createball(Color c)
        {
            GameObject ball = Instantiate(prefab, new Vector3(UnityEngine.Random.Range(-20,20), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-20,20)), Quaternion.identity);
            balls.Add(ball);
            Material mat = ball.GetComponent<MeshRenderer>().material;

            if (mat.shader.name == "Universal Render Pipeline/Lit")
            {
                mat.SetColor("_BaseColor", c);
            }


            DestroyBall();
            return ball;
        }
        public void DestroyBall()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                Destroy(balls[i],3f);
            }
        }

        private void Start()
        {
            List<GameObject> Secondball = new List<GameObject>();

            for (int i = 0; i < ballspawn; i++)
            {

                float r = UnityEngine.Random.Range(0f, 1f);
                float g = UnityEngine.Random.Range(0f, 1f);
                float b = UnityEngine.Random.Range(0f, 1f);
                Color randomColor = new Color(r, g, b, 1f);
                Debug.Log(randomColor);
                GameObject newBall = createball(randomColor);
                Secondball.Add(newBall);
            }
        }        
        void Update()
        {
            float r = UnityEngine.Random.Range(0f, 1f);
            float g = UnityEngine.Random.Range(0f, 1f);
            float b = UnityEngine.Random.Range(0f, 1f);
            Color randomColor = new Color(r, g, b, 1f);
            worldTime += Time.deltaTime;
            if(worldTime > 1f)
            {
                createball(randomColor);
                worldTime = 0f;
            }
        }
    }
