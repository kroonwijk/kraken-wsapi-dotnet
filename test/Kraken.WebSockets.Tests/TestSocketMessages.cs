using System.Diagnostics.CodeAnalysis;
using System.IO;
using Kraken.WebSockets.Messages;
using Ping = Kraken.WebSockets.Messages.Ping;

namespace Kraken.WebSockets.Tests
{
    [ExcludeFromCodeCoverage]
    public static class TestSocketMessages
    {
        #region Ping

        public const string PingMessage = @"{""event"":""ping""}";

        public static readonly Ping Ping = new Ping();

        #endregion

        #region Heartbeat

        public static string Heartbeat => File.ReadAllText("data/heartbeat.json");

        #endregion

        #region SystemStatus

        public const string SystemStatusMessage =
            "{\"connectionID\":8628615390848610222,\"event\": \"systemStatus\",\"status\": \"online\",\"version\": \"1.0.0\"}";

        public static readonly SystemStatus SystemStatus = new SystemStatus
        {
            Status = "online",
            ConnectionId = 8628615390848610222,
            Version = "1.0.0"
        };

        #endregion

        #region SubscriptionStatus1

        public static readonly SubscriptionStatus SubscriptionStatus1 = new SubscriptionStatus
        {
            ChannelId = 123,
            Pair = "XBT/EUR",
            Status = "subscribed"
        };

        public const string SubscriptionStatus1Message =
            @"{""channelID"":123,""event"":""subscriptionStatus"",""pair"":""XBT/EUR"",""status"":""subscribed""}";

        #endregion

        #region SubScriptionStatusNoChannelId

        public static readonly SubscriptionStatus SubScriptionStatusNoChannelId = new SubscriptionStatus
        {
            Pair = "XBT/EUR",
            Status = "subscribed"
        };

        public const string SubScriptionStatusNoChannelIdMessage =
            @"{""event"":""subscriptionStatus"",""pair"":""XBT/EUR"",""status"":""subscribed""}";


        #endregion

        #region UnsubscribeChannelId

        public static readonly Unsubscribe UnsubscribeChannelId = new Unsubscribe(123);

        public static string UnsubscribeChannelIdMessage
        {
            get { return File.ReadAllText("data/unsubscribe2.json"); }
        }

        #endregion

        #region Ticker

        public static string TickerMessage
        {
            get { return File.ReadAllText("data/ticker.json"); }
        }

        #endregion

        #region Ohlc

        public static string OhlcMessage
        {
            get
            {
                return File.ReadAllText("data/ohlc.json");
            }
        }

        #endregion

        #region Trade

        public static string TradeMessage
        {
            get
            {
                return File.ReadAllText("data/trade.json");
            }
        }

        #endregion

        #region Spread

        public static string SpreadMessage
        {
            get
            {
                return File.ReadAllText("data/spread.json");
            }
        }

        #endregion

        #region BookSnapshot

        public static string BookSnapshotMessage
        {
            get
            {
                return File.ReadAllText("data/bookSnapshot.json");

            }
        }

        #endregion

        #region BookUpdate

        public static string BookUpdateMessageOnlyAsks
        {
            get
            {
                return File.ReadAllText("data/bookUpdate1.json");
            }
        }

        public static string BookUpdateMessageOnlyBids
        {
            get
            {
                return File.ReadAllText("data/bookUpdate2.json");
            }
        }

        public static string BookUpdateCompleteMessage
        {
            get
            {
                return File.ReadAllText("data/bookUpdate3.json");
            }
        }

        public static string BookUpdateAsksRepublished
        {
            get
            {
                return File.ReadAllText("data/bookUpdateRepublished.json");
            }
        }

        #endregion

        #region OwnTradesReceived

        public static string OwnTradesMessage => File.ReadAllText("data/ownTrades.json");

        #endregion

        #region OpenOrders

        public static string OpenOrdersMessage => File.ReadAllText("data/openOrders.json");

        #endregion

        #region AddOrder

        public static string AddOrder => File.ReadAllText("data/addOrder.json");
        public static string AddOrderConditionalClose => File.ReadAllText("data/addOrderConditionalClose.json");

        #endregion

        #region AddOrderStatus

        public static string AddOrderStatus => File.ReadAllText("data/addOrderStatus.json");
        public static string AddOrderStatusError => File.ReadAllText("data/addOrderStatusError.json");

        #endregion

        #region CancelOrderStatus

        public static string CancelOrderStatus => File.ReadAllText("data/cancelOrderStatus.json");
        public static string CancelOrderStatusError => File.ReadAllText("data/cancelOrderStatusError.json");

        #endregion
    }
}