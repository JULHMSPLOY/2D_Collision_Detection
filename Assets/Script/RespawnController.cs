using UnityEngine;
public class RespawnController : MonoBehaviour
{
    [Header("Respawn Settings")]
    public Transform respawnPoint; // จุดเกิดใหม่
    public string hazardTag = "Hazard"; // แท็กสิ่งที่ฆ่าผู ้เล่น
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player ชนกับบางอย่าง...");
        if (other.CompareTag(hazardTag))
        {
            Debug.Log("Player ชนกับ Hazard! กำ ลัง Respawn...");
            if (respawnPoint != null)
            {
                Debug.Log("Respawn ที่ตำ แหน่ง: " + respawnPoint.position);
                transform.position = respawnPoint.position;
            }
            else
            {
                Debug.LogWarning("respawnPoint ยังไม่ได ้ถูกกำ หนดใน Inspector!");
            }
        }
    }
}
