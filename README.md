# 跨多媒體播放器 

這是一個結合了 **Windows Forms UI** 與 **WPF MediaEngine** 優點的多媒體播放器。透過整合 WPF 的 `MediaElement` 控制項，本專案能夠流暢地播放包含 MP3、WAV、MP4 及 AVI 在內的多種影音格式，並提供完整的視訊渲染與播放控制。

## 🚀 核心功能

- **全方位格式支援**：支援音訊 (MP3, WAV) 與影片 (MP4, AVI, WMV) 等主流多媒體檔案。
- **跨技術整合 (WinForms + WPF)**：
  - 使用 `ElementHost` 將 WPF 的 `MediaElement` 嵌入 WinForms 視窗。
  - 兼具 WinForms 的開發便利性與 WPF 強大的多媒體編碼支援。
- **動態播放控制**：
  - **智慧切換**：單一按鈕實現「播放/暫停」狀態切換。
  - **進度拖拉**：支援 `TrackBar` 雙向同步，既能顯示進度，也能手動跳轉時間點。
  - **一鍵重播**：快速歸零並重新啟動媒體流。
- **即時狀態顯示**：狀態列會動態顯示目前檔案名稱與播放狀態（正在播放、已暫停、已停止）。

## 🖥️ 使用畫面展示

<img width="1008" height="591" alt="image" src="https://github.com/user-attachments/assets/13cc7103-c6f4-4b09-aacf-cc2a10008011" />


### 📽️ 操作說明
1. **開啟檔案**：點擊 `Open` 選擇影片或音樂檔。
2. **視訊區域**：中央區域將根據媒體類型自動渲染影像。
3. **進度控制**：下方的拉桿會隨著播放進度移動，亦可直接點擊拖動。

## 🛠️ 技術細節

### 1. 核心技術：`MediaElement`
本專案捨棄了傳統的 `AxWindowsMediaPlayer`，改用更現代的 `System.Windows.Controls.MediaElement`。
*   **優勢**：更好的資源管理與更豐富的事件回饋（如 `MediaOpened` 取得影片長度）。

### 2. 狀態同步邏輯
使用 `Timer` 配合 `isDragging` 旗標來解決進度更新衝突：
```csharp
private void UpdateTimer_Tick(object sender, EventArgs e)
{
    // 只有在使用者沒有拖動進度條時，才由系統自動更新位置
    if (!isDragging && wpfMediaElement.NaturalDuration.HasTimeSpan)
    {
        trackBarProgress.Value = (int)wpfMediaElement.Position.TotalSeconds;
    }
}
