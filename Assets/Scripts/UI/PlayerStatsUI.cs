using UnityEngine;
using TMPro;
using GameTest.Health;
using GameTest.Gold;
using GameTest.Rating;

namespace GameTest.UI
{
    public class PlayerStatsUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textHealth;
        [SerializeField] private TMP_Text _textGold;
        [SerializeField] private TMP_Text _textRate;

        private void Awake()
        {
            UpdateStats();
            HealthManager.Instance().Changed += UpdateHealth;
            GoldManager.Instance().Changed += UpdateGold;
            RatingManager.Instance().Changed += UpdateRating;
        }

        private void UpdateStats()
        {
            _textHealth.text = $"{HealthManager.Instance().CurrentValue}";
            _textGold.text = $"{GoldManager.Instance().CurrentValue}";
            _textRate.text = $"{RatingManager.Instance().CurrentValue}";
        }

        private void UpdateHealth()
        {
            _textHealth.text = $"{HealthManager.Instance().CurrentValue}";
        }
        private void UpdateGold()
        {
            _textGold.text = $"{GoldManager.Instance().CurrentValue}";
        }
        private void UpdateRating()
        {
            _textRate.text = $"{RatingManager.Instance().CurrentValue}";
        }
    }

}
